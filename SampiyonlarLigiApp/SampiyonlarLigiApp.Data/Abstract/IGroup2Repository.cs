using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface IGroup2Repository : IRepository<Group2>
    {
        void IsActiveUpdate(int id);
        Group2 group1();

    }
}
