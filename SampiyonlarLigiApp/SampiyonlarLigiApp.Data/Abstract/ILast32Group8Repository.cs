using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface ILast32Group8Repository : IRepository<Last32Group8>
    {
        bool IsTeam(string teamCountry);

    }
}
