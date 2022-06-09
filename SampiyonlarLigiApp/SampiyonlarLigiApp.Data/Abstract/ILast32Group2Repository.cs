using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface ILast32Group2Repository : IRepository<Last32Group2>
    {
        bool IsTeam(string teamCountry);
    }
}
