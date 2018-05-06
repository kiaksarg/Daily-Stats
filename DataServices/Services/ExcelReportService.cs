using DataModel;
using DomainClasses;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace DataServices.Services
{
    public class ExcelReportService : IExcelReportService
    {
        private readonly IPropertyService _propertyService;
        private readonly IStateService _stateService;
        ISettingService _settingService;
        public string ExcelPath { get; set; }
        private Application ExcelApp { get; set; }
        private Workbook WB { get; set; }
        private Worksheet Sheet { get; set; }
        public ExcelReportService(IPropertyService PropertyService, IStateService StateService, ISettingService SettingService, string path)
        {
            _propertyService = PropertyService;
            _settingService = SettingService;
            ExcelPath = path;

            ExcelApp = new Application();
            ExcelApp.Visible = true;

            WB = ExcelApp.Workbooks.Open(ExcelPath);
            Sheet = (Worksheet)WB.Worksheets[1];

            _stateService = StateService;
        }
        void ResetStates()
        {
            foreach (var state in _stateService.GetList().Where(x => x.Showable))
            {
                foreach (var property in _propertyService.GetList())
                {
                    Sheet.Range[state.Address + property.Address].Value = null;
                }
            }
        }
        public void ResetTotals(List<Person> people, string totalsAddress)
        {
            var res = people.GroupBy(x => x.Property_Id).Select(y => new
            {
                pId = y.Key,
                people = y
            });
            foreach (var item in res)
            {
                if (item.pId is null) continue;
                var Property = _propertyService.Get(item.pId ?? 1);

                foreach (var person in item.people)
                {


                    Sheet.Range[totalsAddress + Property.Address].Value = 0;



                }
            }


        }
        public void ResetLists(string alphaPart, int numberPart, int count)
        {
            for (int i = numberPart; i < numberPart + count; i++)
            {
                Sheet.Range[alphaPart + i].Value = "";

            }

        }
        public void WriteListTitless(string alphaPart, int numberPart, List<Person> people, List<State> states)
        {


            ResetLists(alphaPart, numberPart, states.Count);

            List<State> Fstate = states.Where(x => x.Showable && (x.Required || people.Any(y => y.State_Id == x.Id))).OrderBy(x => x.Address).ToList();
            foreach (var item in Fstate)
            {
                Sheet.Range[getLstStaetAddress(item.Id, alphaPart, numberPart, Fstate)].Value = item.Caption + ":";
            }

        }
        string getLstStaetAddress(long PId, string alphaPart, int numberPart, List<State> states)
        {

            return alphaPart + (states.Select((Value, Index) => new { Value, Index })
             .Single(p => p.Value.Id == PId).Index + numberPart);
        }
        public void Totals(List<Person> people)
        {

            var totalsAddress = _settingService.Load().TotalsAddress;

            ResetTotals(people, totalsAddress);

            var res = people.GroupBy(x => x.Property_Id).Select(y => new
            {
                pId = y.Key,
                people = y
            });
            foreach (var item in res)
            {
                if (item.pId is null) continue;
                var Property = _propertyService.Get(item.pId ?? 1);

                foreach (var person in item.people)
                {
                    Sheet.Range[totalsAddress + Property.Address].Value = (Sheet.Range[totalsAddress + Property.Address].Value ?? 0) + 1;
                }
            }

        }

        public void WriteStates(List<Person> people)
        {
            ResetStates();
            var res = people.GroupBy(x => x.State_Id).Select(y => new
            {
                sId = y.Key,
                people = y
            });

            foreach (var item in res)
            {
                var Pstate = _stateService.Get(item.sId ?? 1);
                if (string.IsNullOrEmpty(Pstate.Address) || string.IsNullOrEmpty(Pstate.Address) || !Pstate.Showable) continue;
                foreach (var person in item.people)
                {
                    if (person.Property_Id is null) continue;

                    var Pproperty = _propertyService.Get(person.Property_Id ?? 0);

                    var address = Pstate.Address + Pproperty.Address;

                    Sheet.Range[address].Value = (Sheet.Range[address].Value ?? 0) + 1;


                }
            }

        }
        public void WriteLists(List<Person> people)
        {
            var states = _stateService.GetList();
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = re.Match(_settingService.Load().LstStartAddress);

            string alphaPart = result.Groups[1].Value;
            int numberPart = Convert.ToInt32(result.Groups[2].Value);



            WriteListTitless(alphaPart, numberPart, people, states);

            string tmpStr = "";
            var res = people.GroupBy(x => x.State_Id).Select(y => new
            {
                sId = y.Key,
                people = y,
                sAddress = _stateService.Get(y.Key ?? 1).Address
            }).OrderBy(x => x.sAddress);

            foreach (var item in res)
            {
                var Pstate = _stateService.Get(item.sId ?? 1);
                tmpStr = Pstate.Caption + ":";
                if (string.IsNullOrEmpty(Pstate.Address) || string.IsNullOrEmpty(Pstate.Address) || !Pstate.Showable) continue;
                foreach (var Ptype in item.people.Where(x => x.Type == 1).OrderBy(x => x.Rank))
                {
                    tmpStr += $"{Ptype.FirstName} {Ptype.LastName}، ";
                }

                foreach (var person in item.people.Where(x => x.Type == 0).OrderBy(x => x.Rank))
                {
                    tmpStr += $"{person.FirstName} {person.LastName}، ";
                }

                Sheet.Range[getLstStaetAddress(Pstate.Id, alphaPart, numberPart, states.Where(x => x.Showable && (x.Required || people.Any(y => y.State_Id == x.Id))).OrderBy(x => x.Address).ToList())].Value = tmpStr.TrimEnd(' ').TrimEnd('،');

            }

        }
        public void Save()
        {
            WB.Save();
        }
        public void SaveAs(string path)
        {
            WB.SaveAs(path);
        }
        public void Close()
        {
            //WB.Close(0);
            //ExcelApp.Quit();

            Marshal.ReleaseComObject(WB);
            Marshal.FinalReleaseComObject(Sheet);
            Marshal.ReleaseComObject(ExcelApp);

            GC.Collect();
            GC.WaitForPendingFinalizers();

        }


    }
}
