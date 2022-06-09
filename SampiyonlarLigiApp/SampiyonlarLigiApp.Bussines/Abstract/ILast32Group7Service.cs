using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface ILast32Group7Service : IRepositoryService<Last32Group7>
    {
        bool IsTeam(string teamCountry);
    }

}
