using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface IGroup4Service : IRepositoryService<Group4>
    {
        void IsActiveUpdate(int id);
        Group4 group1();
    }
}
