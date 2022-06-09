using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface IGroup3Service : IRepositoryService<Group3>
    {
        void IsActiveUpdate(int id);
        Group3 group1();
    }
}
