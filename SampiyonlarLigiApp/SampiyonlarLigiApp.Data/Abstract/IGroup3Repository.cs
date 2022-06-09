using SampiyonlarLigiApp.Entity;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface IGroup3Repository : IRepository<Group3>
    {
        void IsActiveUpdate(int id);
        Group3 group1();

    }
}
