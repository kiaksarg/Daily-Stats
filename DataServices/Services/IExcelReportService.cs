using System.Collections.Generic;
using DataModel;

namespace DataServices.Services
{
    public interface IExcelReportService
    {
        string ExcelPath { get; set; }

        void Totals(List<Person> people);
        void Close();
        void Save();
        void SaveAs(string path);
        void WriteStates(List<Person> people);
        void WriteLists(List<Person> people);
    }
}