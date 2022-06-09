using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface ILast32Group4Service : IRepositoryService<Last32Group4>
    {
        bool IsTeam(string teamCountry);
    }

}
