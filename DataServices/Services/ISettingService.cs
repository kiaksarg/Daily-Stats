using DomainClasses;

namespace DataServices.Services
{
    public interface ISettingService
    {
       

        Setting Load();
        void Save(Setting setting);
    }
}