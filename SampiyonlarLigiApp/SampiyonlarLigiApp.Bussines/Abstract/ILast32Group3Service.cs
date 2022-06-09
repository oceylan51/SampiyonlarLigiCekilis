using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface ILast32Group3Service : IRepositoryService<Last32Group3>
    {
        bool IsTeam(string teamCountry);
    }

}
