using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface IGroup1Service : IRepositoryService<Group1>
    {
        void IsActiveUpdate(int id);
        Group1 group1();
    }
}
