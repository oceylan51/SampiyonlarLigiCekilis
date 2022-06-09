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
    public class FixtureManager : IFixtureService
    {
        private IFixtureRepository _fixtureRepository;

        public FixtureManager(IFixtureRepository fixtureRepository)
        {
            _fixtureRepository = fixtureRepository;
        }

        public void Create(Fixture fixture)
        {
            _fixtureRepository.Create(fixture);
        }

        public List<Fixture> GetAll()
        {
            return _fixtureRepository.GetAll();
        }

        public void RangeCreate(List<Fixture> fixture)
        {
            _fixtureRepository.RangeCreate(fixture);
        }

        public void Update(Fixture fixture)
        {
            _fixtureRepository.Update(fixture);
        }
    }
}
