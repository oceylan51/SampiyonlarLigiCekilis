using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Last32Group4Manager : ILast32Group4Service
    {
        private ILast32Group4Repository _last32Group4Repository;

        public Last32Group4Manager(ILast32Group4Repository last32Group4Repository)
        {
            _last32Group4Repository = last32Group4Repository;
        }

        public void Create(Last32Group4 entity)
        {
            _last32Group4Repository.Create(entity);
        }

        public List<Last32Group4> GetAll()
        {
            return _last32Group4Repository.GetAll();
        }

        public Last32Group4 GetById(int id)
        {
            return _last32Group4Repository.GetById(id);
        }

        public bool IsTeam(string teamCountry)
        {
            return _last32Group4Repository.IsTeam(teamCountry);
        }
    }
}
