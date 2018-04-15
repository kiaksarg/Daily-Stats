using System.Collections.Generic;
using DataModel;
using System;

namespace DataServices.Services
{
    public interface IPersonService
    {
        object GetEnabledPeople();
        object GetDisabledPeople();
        void Insert(Person person);
        void EditState(long id, PersonState state);
        Person Fetch(long id);
        void SetStartDate(long id, DateTime date);
        void SetEndDate(long id, DateTime date);
        List<Person> EnabledPeople();
        List<Person> GetFarAgents();
        List<Person> GetCloseAgents();
        List<Person> GetState(PersonState state);
        object GetEnabledPeopleWithRank();
        List<Person> GetBede();
        void SetDate(long id, DateTime sDate, DateTime eDate);
        List<Person> GetPBState();
        void SetEnabled(long id, bool flag);
        Person GetPerson(long id);
        void EditPerson(Person item);
        int GetDvCount();
        void DeleteAllDv();
        void DeleteDv(int count);
    }
}