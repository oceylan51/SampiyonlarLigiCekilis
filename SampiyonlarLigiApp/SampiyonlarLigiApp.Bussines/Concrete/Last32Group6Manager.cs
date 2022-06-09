using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Last32Group6Manager : ILast32Group6Service
    {
        private ILast32Group6Repository _last32Group6Repository;

        public Last32Group6Manager(ILast32Group6Repository last32Group6Repository)
        {
            _last32Group6Repository = last32Group6Repository;
        }

        public void Create(Last32Group6 entity)
        {
            _last32Group6Repository.Create(entity);
        }

        public List<Last32Group6> GetAll()
        {
            return _last32Group6Repository.GetAll();
        }

        public Last32Group6 GetById(int id)
        {
            return _last32Group6Repository.GetById(id);
        }

        public bool IsTeam(string teamCountry)
        {
            return _last32Group6Repository.IsTeam(teamCountry);
        }
    }
}
