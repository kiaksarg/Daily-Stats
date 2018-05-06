using DataLayer.Context;
using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DataServices.Services
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Person> _person;
        private readonly IPropertyService _propertyService;
        public PersonService(IUnitOfWork unitOfWork, IPropertyService PropertyService)
        {
            _unitOfWork = unitOfWork;
            _person = _unitOfWork.Set<Person>();
            _propertyService = PropertyService;
        }

        public void Insert(Person person)
        {
            _person.Add(person);
        }

        public object GetEnabledPeople()
        {
            return _person.Where(x => x.Enabled).Select(x => new
            {
                Id = x.Id,
                Name = x.FirstName,
                LastName = x.LastName,
                Rank = x.Rank,
                Type = (x.Type == 0) ? "پایور" : "وظیفه"
            }).ToList();
        }
        public object GetEnabledPeopleWithRank()
        {

            return _person.Where(x => x.Enabled).ToList().Select(x => new
            {
                Id = x.Id,
                Name = x.FirstName,
                LastName = x.LastName,
                Rank = x.Rank.toRank(),
                Type = (x.Type == 0) ? "پایور" : "وظیفه"
            }).ToList();
        }
        public List<Person> EnabledPeople()
        {
            return _person.Where(x => x.Enabled).ToList();
        }
        public object GetDisabledPeople()
        {
            return _person.Where(x => !x.Enabled).ToList().Select(x => new
            {
                Id = x.Id,
                Title = x.Title,
                Name = x.FirstName,
                LastName = x.LastName,
                Rank = x.Rank.toRank(),
                Type = (x.Type == 0) ? "اول" : "دوم"
            }).ToList();
        }
        public object GetEnabledPeople_Grid()
        {
            return _person.Where(x => x.Enabled).ToList().Select(x => new
            {
                Id = x.Id,
                Title=x.Title,
                Name = x.FirstName,
                LastName = x.LastName,
                Rank = _propertyService.Get(x.Property_Id ?? 1).Caption,
                Type = (x.Type == 0) ? "اول" : "دوم"
            }).ToList();
        }
        public void EditState(long id, long sId)
        {
            var Person = _person.Where(x => x.Id == id).FirstOrDefault();
            Person.State_Id = sId;
            _unitOfWork.MarkAsChanged(Person);


        }
        public Person Fetch(long id)
        {
            return _person.Where(x => x.Id == id).FirstOrDefault();

        }

        public void SetStartDate(long id, DateTime date)
        {
            var Person = _person.Where(x => x.Id == id).FirstOrDefault();
            Person.OffStartDate = date;
            _unitOfWork.MarkAsChanged(Person);
            _unitOfWork.SaveAllChanges();
        }
        public void SetDate(long id, DateTime sDate, DateTime eDate)
        {
            var Person = _person.Where(x => x.Id == id).FirstOrDefault();
            Person.OffStartDate = sDate;
            Person.OffEndDate = eDate;
            _unitOfWork.MarkAsChanged(Person);

        }
        public void SetEndDate(long id, DateTime date)
        {
            var Person = _person.Where(x => x.Id == id).FirstOrDefault();
            Person.OffEndDate = date;
            _unitOfWork.MarkAsChanged(Person);
            _unitOfWork.SaveAllChanges();
        }
        public List<Person> GetFarAgents()
        {
            return _person.Where(x => x.Enabled).ToList();
            //return _person.Where(x => x.Enabled && x.State == (int)PersonState.RemotAgent).ToList();
        }
        public List<Person> GetCloseAgents()
        {
            //return _person.Where(x => x.Enabled && x.State == (int)PersonState.CloseAgent).ToList();
            return _person.Where(x => x.Enabled).ToList();
        }

        public List<Person> GetState(PersonState state)
        {
            //return _person.Where(x => x.Enabled && x.State == (int)state).ToList();
            return _person.Where(x => x.Enabled).ToList();
        }
        public List<Person> GetBede()
        {
            return _person.Where(x => x.Enabled && x.IsBede).ToList();
        }
        public List<Person> GetPBState()
        {
            //_person.Where(x => x.Enabled && x.State != 1 && x.State != 2 && x.State != 12).ToList().Where(x => x.OffStartDate > DateTime.Now.AddYears(-100) && x.OffEndDate > DateTime.Now.AddYears(-100)).ToList();
            return _person.Where(x => x.Enabled).ToList();
        }
        public void SetEnabled(long id, bool flag)
        {
            var Person = _person.Where(x => x.Id == id).FirstOrDefault();
            Person.Enabled = flag;
            _unitOfWork.MarkAsChanged(Person);
        }
        public Person GetPerson(long id)
        {
            return _person.Where(x => x.Id == id).FirstOrDefault();

        }
        public void EditPerson(Person item)
        {
            var Person = _person.Where(x => x.Id == item.Id).FirstOrDefault();
            Person.Enabled = item.Enabled;
            Person.FirstName = item.FirstName;
            Person.LastName = item.LastName;
            Person.Rank = item.Rank;
            Person.Enabled = item.Enabled;
            Person.Type = item.Type;
            _unitOfWork.MarkAsChanged(Person);
        }
        public int GetDvCount()
        {
            return _person.Where(x => x.FirstName == "dv0102").Count();
        }
        public void DeleteAllDv()
        {
            foreach (var item in _person.Where(x => x.FirstName == "dv0102"))
            {
                _person.Remove(item);
            }

        }
        public void DeleteDv(int count)
        {
            foreach (var item in _person.Where(x => x.FirstName == "dv0102").Take(count))
            {
                _person.Remove(item);
            }
        }
    }
}
