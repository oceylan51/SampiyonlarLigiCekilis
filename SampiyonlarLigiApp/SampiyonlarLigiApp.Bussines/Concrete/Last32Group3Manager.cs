using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Last32Group3Manager : ILast32Group3Service
    {
        private ILast32Group3Repository _last32Group3Repository;

        public Last32Group3Manager(ILast32Group3Repository last32Group3Repository)
        {
            _last32Group3Repository = last32Group3Repository;
        }

        public void Create(Last32Group3 entity)
        {
            _last32Group3Repository.Create(entity);
        }

        public List<Last32Group3> GetAll()
        {
            return _last32Group3Repository.GetAll();
        }

        public Last32Group3 GetById(int id)
        {
            return _last32Group3Repository.GetById(id);
        }

        public bool IsTeam(string teamCountry)
        {
            return _last32Group3Repository.IsTeam(teamCountry);
        }
    }
}
