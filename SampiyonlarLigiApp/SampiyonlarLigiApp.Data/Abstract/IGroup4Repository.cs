using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface IGroup4Repository : IRepository<Group4>
    {
        void IsActiveUpdate(int id);
        Group4 group1();

    }
}
