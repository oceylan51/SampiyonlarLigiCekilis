using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface ILast32Group2Service : IRepositoryService<Last32Group2>
    {
        bool IsTeam(string teamCountry);

    }

}
