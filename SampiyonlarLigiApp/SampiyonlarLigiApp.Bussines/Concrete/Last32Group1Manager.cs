using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Last32Group1Manager : ILast32Group1Service
    {
        private ILast32Group1Repository _last32Group1Repository;

        public Last32Group1Manager(ILast32Group1Repository last32Group1Repository)
        {
            _last32Group1Repository = last32Group1Repository;
        }

        public void Create(Last32Group1 entity)
        {
            _last32Group1Repository.Create(entity);
        }

        public List<Last32Group1> GetAll()
        {
            return _last32Group1Repository.GetAll();
        }

        public Last32Group1 GetById(int id)
        {
            return _last32Group1Repository.GetById(id);

        }

        public bool IsTeam(string teamCountry)
        {
            return _last32Group1Repository.IsTeam(teamCountry);
        }
    }
}
