using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Group4Manager : IGroup4Service
    {
        private IGroup4Repository _group4Repository;

        public Group4Manager(IGroup4Repository group4Repository)
        {
            _group4Repository = group4Repository;
        }
        public Group4 group1()
        {
            return _group4Repository.group1();
        }
        public void Create(Group4 entity)
        {
            _group4Repository.Create(entity);
        }

        public List<Group4> GetAll()
        {
            return _group4Repository.GetAll();
        }

        public Group4 GetById(int id)
        {
            return _group4Repository.GetById(id);

        }
        public void IsActiveUpdate(int id)
        {
            _group4Repository.IsActiveUpdate(id);
        }
    }
}
