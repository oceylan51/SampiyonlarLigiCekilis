using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Linq;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreGroup4Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Group4>, IGroup4Repository
    {
        public Group4 group1()
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                return context.Group4.Where(x => x.IsActive == false).FirstOrDefault();
            }
        }
        public void IsActiveUpdate(int id)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                context.Group4.Find(id).IsActive = true;
                context.SaveChanges();
            }
        }
    }
}
