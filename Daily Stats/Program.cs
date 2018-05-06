using DataLayer.Context;
using DataModel;
using DataServices;
using DataServices.Services;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Stats
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists($"{System.Reflection.Assembly.GetExecutingAssembly().Location}\\Report.docx"))
            {
                try
                {

                    using (var file = new System.IO.FileStream(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Report.docx", System.IO.FileMode.Create, System.IO.FileAccess.Write))
                    {
                        //file.Write(TheGreatKiaksarg.Resource.Report, 0, TheGreatKiaksarg.Resource.Report.Length);
                    }
                }
                catch (Exception)
                {

                }
            }

            var container = Container.For<ConsoleRegistry>();
            IUnitOfWork _uow = container.GetInstance<IUnitOfWork>();
            var _personService = container.GetInstance<IPersonService>();
            var _stateService = container.GetInstance<IStateService>();
            var _propertyService = container.GetInstance<IPropertyService>();
            var _settingService = container.GetInstance<ISettingService>();



//            var tmp = _settingService.Load();
//            tmp.Ranks = @"
//";
//            _settingService.Save(tmp);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(_personService, _propertyService, _stateService, _uow, _settingService));
        }
        public class ConsoleRegistry : Registry
        {
            public ConsoleRegistry()
            {
                Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });

                // requires explicit registration; doesn't follow convention

                For<IPersonService>().Use<PersonService>();
                For<IStateService>().Use<StateService>();
                For<IPropertyService>().Use<PropertyService>();
                For<ISettingService>().Use<SettingService>();

                For<IExcelReportService>().Use<ExcelReportService>();
                For<IUnitOfWork>().LifecycleIs(Lifecycles.Singleton).Use<Context>();


            }
        }
    }
}
