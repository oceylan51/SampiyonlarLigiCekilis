using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface ILast32Group3Repository : IRepository<Last32Group3>
    {
        bool IsTeam(string teamCountry);
    }
}
