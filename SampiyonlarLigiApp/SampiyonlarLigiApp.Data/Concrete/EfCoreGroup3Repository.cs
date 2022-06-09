using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Linq;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreGroup3Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Group3>, IGroup3Repository
    {
        public Group3 group1()
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                return context.Group3.Where(x => x.IsActive == false).FirstOrDefault();
            }
        }
        public void IsActiveUpdate(int id)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                context.Group3.Find(id).IsActive = true;
                context.SaveChanges();
            }
        }
    }
}
