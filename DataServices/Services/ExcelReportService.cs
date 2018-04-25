using DataModel;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
namespace DataServices.Services
{
    public class ExcelReportService : IExcelReportService
    {
        private readonly IPropertyService _propertyService;

        public string ExcelPath { get; set; }
        private Application ExcelApp { get; set; }
        private Workbook WB { get; set; }
        private Worksheet Sheet { get; set; }
        public ExcelReportService(IPropertyService PropertyService, string path)
        {
            _propertyService = PropertyService;
            ExcelPath = path;

            ExcelApp = new Application();
            ExcelApp.Visible = true;

            WB = ExcelApp.Workbooks.Open(ExcelPath);
            Sheet = (Worksheet)WB.Worksheets[1];
        }
        public void Totals(List<Person> people, string totalsAddress)
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


                    Sheet.Range[totalsAddress + Property.Address].Value = Sheet.Range[totalsAddress + Property.Address].Value + 1;



                }
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
