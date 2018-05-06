using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainClasses;
using System.IO;

namespace DataServices.Services
{
    public class SettingService : ISettingService
    {
        public string Base { get; set; }
        public SettingService()
        {
            Base = $"{System.Reflection.Assembly.GetExecutingAssembly().Location}\\..\\settings.json";
        }
        public Setting Load()
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Setting>(File.ReadAllText(Base));
            }
            catch
            {
                //Default setting
                var DefaultSetting = new Setting()
                {
                    Name = "شعبه ؟",
                    HeaderDateAddress = "N1",
                    HeaderNameAddress = "F1",
                    HeaderDayAddress = "A1",
                    IsPersianDate = true,
                    TotalsAddress = "C",
                    WriteHeader = true,
                    Ranks = @"
رئیس شعبه
معاون
کارمند
",
                    LstStartAddress = "13"
                };
                if (!File.Exists(Base)) Save(DefaultSetting);
                return DefaultSetting;
            }
        }

        public void Save(Setting setting)
        {
            File.WriteAllText(Base, Newtonsoft.Json.JsonConvert.SerializeObject(setting));
        }
    }
}
