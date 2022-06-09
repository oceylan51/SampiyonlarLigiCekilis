using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Group2Manager : IGroup2Service
    {
        private IGroup2Repository _group2Repository;

        public Group2Manager(IGroup2Repository group2Repository)
        {
            _group2Repository = group2Repository;
        }

        public void Create(Group2 entity)
        {
            _group2Repository.Create(entity);

        }
        public Group2 group1()
        {
            return _group2Repository.group1();
        }

        public List<Group2> GetAll()
        {
            return _group2Repository.GetAll();
        }

        public Group2 GetById(int id)
        {
            return _group2Repository.GetById(id);

        }
        public void IsActiveUpdate(int id)
        {
            _group2Repository.IsActiveUpdate(id);
        }
    }
}
