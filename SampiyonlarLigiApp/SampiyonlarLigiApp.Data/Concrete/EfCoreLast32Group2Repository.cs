using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Linq;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreLast32Group2Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Last32Group2>, ILast32Group2Repository
    {
        public bool IsTeam(string teamCountry)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                if (context.last32Group2.Where(x => x.TeamCountry == teamCountry).Count() == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
