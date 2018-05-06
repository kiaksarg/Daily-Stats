using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainClasses
{
    public class Setting
    {
        public string Name { get; set; }
        public string TotalsAddress { get; set; }
        public bool WriteHeader { get; set; }
        public string HeaderDayAddress { get; set; }
        public string HeaderNameAddress { get; set; }
        public string HeaderDateAddress { get; set; }
        public bool IsPersianDate { get; set; }
        public string Ranks { get; set; }
        public string LstStartAddress { get; set; }
        public string Titles { get; set; }
        public string ReportFileAddress { get; set; }

    }
}
