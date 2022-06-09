using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface IGroup2Service : IRepositoryService<Group2>
    {
        void IsActiveUpdate(int id);
        Group2 group1();
    }
}
