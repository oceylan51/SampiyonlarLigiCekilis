using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreLast32Group1Repository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Last32Group1>, ILast32Group1Repository
    {
        public bool IsTeam(string teamCountry)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                if (context.last32Group1.Where(x => x.TeamCountry == teamCountry).Count() == 0)
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
