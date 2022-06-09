using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Last32Group5Manager : ILast32Group5Service
    {
        private ILast32Group5Repository _last32Group5Repository;

        public Last32Group5Manager(ILast32Group5Repository last32Group5Repository)
        {
            _last32Group5Repository = last32Group5Repository;
        }

        public void Create(Last32Group5 entity)
        {
            _last32Group5Repository.Create(entity);
        }

        public List<Last32Group5> GetAll()
        {
            return _last32Group5Repository.GetAll();
        }

        public Last32Group5 GetById(int id)
        {
            return _last32Group5Repository.GetById(id);
        }

        public bool IsTeam(string teamCountry)
        {
            return _last32Group5Repository.IsTeam(teamCountry);
        }
    }
}
