using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Linq;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreGroup2Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Group2>, IGroup2Repository
    {
        public Group2 group1()
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                return context.Group2.Where(x => x.IsActive == false).FirstOrDefault();
            }
        }
        public void IsActiveUpdate(int id)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                context.Group2.Find(id).IsActive = true;
                context.SaveChanges();
            }
        }
    }
}
