using DataModel;
using System.Collections.Generic;

namespace DataServices.Services
{
    public interface IPropertyService
    {
        void Delete(long id);
        void Edit(Property property);
        object Get();
        Property Get(long id);
        void Insert(Property property);
        void setEnabled(long id, bool enabled);
        List<Property> GetList();
    }
}