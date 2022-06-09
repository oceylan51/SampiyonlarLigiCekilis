using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Last32Group8Manager : ILast32Group8Service
    {
        private ILast32Group8Repository _last32Group8Repository;

        public Last32Group8Manager(ILast32Group8Repository last32Group8Repository)
        {
            _last32Group8Repository = last32Group8Repository;
        }

        public void Create(Last32Group8 entity)
        {
            _last32Group8Repository.Create(entity);
        }

        public List<Last32Group8> GetAll()
        {
            return _last32Group8Repository.GetAll();
        }

        public Last32Group8 GetById(int id)
        {
            return _last32Group8Repository.GetById(id);
        }

        public bool IsTeam(string teamCountry)
        {
            return _last32Group8Repository.IsTeam(teamCountry);
        }
    }
}
