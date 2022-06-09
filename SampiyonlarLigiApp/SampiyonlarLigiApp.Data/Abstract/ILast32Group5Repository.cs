using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface ILast32Group5Repository : IRepository<Last32Group5>
    {
        bool IsTeam(string teamCountry);

    }
}
