using DataLayer.Context;
using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Property> _property;
        public PropertyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _property = _unitOfWork.Set<Property>();
        }

        public void Insert(Property property)
        {
            _property.Add(property);
        }

        public object Get()
        {
            return _property.Select(x => new
            {
                id=x.Id,
              
                Caption = x.Caption,
     
                Enabled = x.Enabled
            }).ToList();

        }


        public Property Get(long id)
        {
            return _property.Find(id);


        }

        public void Edit(Property property)
        {
            _unitOfWork.MarkAsChanged(property);
        }

        public void setEnabled(long id, bool enabled)
        {
            var entity = _property.Find(id);
            entity.Enabled = enabled;
            _unitOfWork.MarkAsChanged(entity);

        }
        public void Delete(long id)
        {
            _unitOfWork.MarkAsDeleted(_property.Find(id));
        }

    }
}
