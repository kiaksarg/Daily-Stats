using System.Collections.Generic;
using DataModel;

namespace DataServices.Services
{
    public interface IStateService
    {
        void Delete(long id);
        void Edit(State state);
        object Get();
        State Get(long id);
        void Insert(State state);
        void setEnabled(long id, bool enabled);
        void setRequired(long id, bool required);
        List<State> GetList();
    }
}