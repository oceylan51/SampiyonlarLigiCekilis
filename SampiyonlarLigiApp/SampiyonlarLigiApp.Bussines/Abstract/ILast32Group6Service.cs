using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface ILast32Group6Service : IRepositoryService<Last32Group6>
    {
        bool IsTeam(string teamCountry);
    }

}
