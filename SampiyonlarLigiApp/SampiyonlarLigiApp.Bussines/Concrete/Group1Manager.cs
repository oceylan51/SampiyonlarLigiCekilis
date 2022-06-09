using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Bussines.Concrete
{

    public class Group1Manager : IGroup1Service
    {
        private IGroup1Repository _group1Repository;

        public Group1Manager(IGroup1Repository group1Repository)
        {
            _group1Repository = group1Repository;
        }

        public void Create(Group1 entity)
        {
            _group1Repository.Create(entity);
        }

        public List<Group1> GetAll()
        {
            return _group1Repository.GetAll();
        }

        public Group1 GetById(int id)
        {
            return _group1Repository.GetById(id);
        }

        public Group1 group1()
        {
            return _group1Repository.group1();
        }

        public void IsActiveUpdate(int id)
        {
            _group1Repository.IsActiveUpdate(id);
        }
    }
}
