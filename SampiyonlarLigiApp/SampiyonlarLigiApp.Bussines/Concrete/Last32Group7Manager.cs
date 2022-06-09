using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Last32Group7Manager : ILast32Group7Service
    {
        private ILast32Group7Repository _last32Group7Repository;

        public Last32Group7Manager(ILast32Group7Repository last32Group7Repository)
        {
            _last32Group7Repository = last32Group7Repository;
        }

        public void Create(Last32Group7 entity)
        {
            _last32Group7Repository.Create(entity);
        }

        public List<Last32Group7> GetAll()
        {
            return _last32Group7Repository.GetAll();
        }

        public Last32Group7 GetById(int id)
        {
            return _last32Group7Repository.GetById(id);
        }

        public bool IsTeam(string teamCountry)
        {
            return _last32Group7Repository.IsTeam(teamCountry);
        }
    }
}
