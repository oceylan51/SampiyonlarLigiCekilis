using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System.Collections.Generic;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class Group3Manager : IGroup3Service
    {
        private IGroup3Repository _group3Repository;

        public Group3Manager(IGroup3Repository group3Repository)
        {
            _group3Repository = group3Repository;
        }
        public Group3 group1()
        {
            return _group3Repository.group1();
        }
        public void Create(Group3 entity)
        {
            _group3Repository.Create(entity);
        }

        public List<Group3> GetAll()
        {
            return _group3Repository.GetAll();
        }

        public Group3 GetById(int id)
        {
            return _group3Repository.GetById(id);
        }
        public void IsActiveUpdate(int id)
        {
            _group3Repository.IsActiveUpdate(id);
        }
    }
}
