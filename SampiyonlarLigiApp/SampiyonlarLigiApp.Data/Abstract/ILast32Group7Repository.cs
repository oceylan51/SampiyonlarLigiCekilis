using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface ILast32Group7Repository : IRepository<Last32Group7>
    {
        bool IsTeam(string teamCountry);

    }
}
