using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface ILast32Group5Service : IRepositoryService<Last32Group5>
    {
        bool IsTeam(string teamCountry);
    }

}
