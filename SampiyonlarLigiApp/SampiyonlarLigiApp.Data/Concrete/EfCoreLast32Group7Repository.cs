using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Linq;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreLast32Group7Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Last32Group7>, ILast32Group7Repository
    {
        public bool IsTeam(string teamCountry)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                if (context.last32Group7.Where(x => x.TeamCountry == teamCountry).Count() == 0)
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
