using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreGroup1Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Group1>, IGroup1Repository
    {
        public Group1 group1()
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                return context.Group1.Where(x => x.IsActive == false).FirstOrDefault();
            }
        }

        public void IsActiveUpdate(int id)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                context.Group1.Find(id).IsActive = true;
                context.SaveChanges();
            }
        }
    }
}
