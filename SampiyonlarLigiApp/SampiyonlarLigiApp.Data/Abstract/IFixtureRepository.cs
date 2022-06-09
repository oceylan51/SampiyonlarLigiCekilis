using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface IFixtureRepository : IRepository<Fixture>
    {
        void RangeCreate(List<Fixture> fixture);
        void Update(Fixture fixture);
    }
}
