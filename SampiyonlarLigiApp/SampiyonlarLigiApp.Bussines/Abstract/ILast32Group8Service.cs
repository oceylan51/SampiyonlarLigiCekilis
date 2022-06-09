using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface ILast32Group8Service : IRepositoryService<Last32Group8>
    {
        bool IsTeam(string teamCountry);
    }

}
