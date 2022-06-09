using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface ILast32Group6Repository : IRepository<Last32Group6>
    {
        bool IsTeam(string teamCountry);

    }
}
