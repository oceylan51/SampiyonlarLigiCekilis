using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Linq;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreLast32Group6Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Last32Group6>, ILast32Group6Repository
    {
        public bool IsTeam(string teamCountry)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                if (context.last32Group6.Where(x => x.TeamCountry == teamCountry).Count() == 0)
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
