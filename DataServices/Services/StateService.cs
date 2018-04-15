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
    public class StateService : IStateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<State> _state;
        public StateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _state = _unitOfWork.Set<State>();
        }

        public void Insert(State state)
        {
            _state.Add(state);
        }

        public object Get()
        {
            return _state.Select(x => new
            {
                id=x.Id,
                Adress = x.Address,
                Caption = x.Caption,
                Showable = x.Showable,
                Enabled = x.Enabled
            }).ToList();

        }


        public State Get(long id)
        {
            return _state.Find(id);


        }

        public void Edit(State state)
        {
            _unitOfWork.MarkAsChanged(state);
        }

        public void setEnabled(long id, bool enabled)
        {
            var entity = _state.Find(id);
            entity.Enabled = enabled;
            _unitOfWork.MarkAsChanged(entity);

        }
        public void Delete(long id)
        {
            _unitOfWork.MarkAsDeleted(_state.Find(id));
        }

    }
}
