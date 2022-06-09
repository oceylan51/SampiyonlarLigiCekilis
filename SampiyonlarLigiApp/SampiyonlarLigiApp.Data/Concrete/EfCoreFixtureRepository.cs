using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreFixtureRepository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Fixture>, IFixtureRepository
    {
        public void RangeCreate(List<Fixture> fixture)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                if (context.Fixture.Count() < 96)
                {
                    context.Fixture.AddRange(fixture);
                    context.SaveChanges();
                }
            }
        }

        public void Update(Fixture fixture)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                context.Fixture.Update(fixture);
                context.SaveChanges();
            }
        }
    }
}
