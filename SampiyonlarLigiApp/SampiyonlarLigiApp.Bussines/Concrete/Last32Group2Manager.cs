using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Last32Group2Manager : ILast32Group2Service
    {
        private ILast32Group2Repository _last32Group2Repository;

        public Last32Group2Manager(ILast32Group2Repository last32Group2Repository)
        {
            _last32Group2Repository = last32Group2Repository;
        }

        public void Create(Last32Group2 entity)
        {
            _last32Group2Repository.Create(entity);
        }

        public List<Last32Group2> GetAll()
        {
            return _last32Group2Repository.GetAll();
        }

        public Last32Group2 GetById(int id)
        {
            return _last32Group2Repository.GetById(id);
        }

        public bool IsTeam(string teamCountry)
        {
            return _last32Group2Repository.IsTeam(teamCountry);
        }
    }
}
