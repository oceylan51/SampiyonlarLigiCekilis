using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface ILast32Group4Repository : IRepository<Last32Group4>
    {
        bool IsTeam(string teamCountry);

    }
}
