using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface IGroup1Repository : IRepository<Group1>
    {
        void IsActiveUpdate(int id);
        Group1 group1();
    }
}
