using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Linq;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreLast32Group4Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Last32Group4>, ILast32Group4Repository
    {
        public bool IsTeam(string teamCountry)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                if (context.last32Group4.Where(x => x.TeamCountry == teamCountry).Count() == 0)
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
