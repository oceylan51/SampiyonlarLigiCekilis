using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface IFixtureService 
    {
        void Create(Fixture fixture);
        void RangeCreate(List<Fixture> fixture);
        List<Fixture> GetAll();
        void Update(Fixture fixture);
    }
}
