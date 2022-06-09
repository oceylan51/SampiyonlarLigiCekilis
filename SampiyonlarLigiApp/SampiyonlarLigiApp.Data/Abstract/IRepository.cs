using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface IRepository<Entity> where Entity : class
    {
        List<Entity> GetAll();
        Entity GetById(int id);
        void Create(Entity entity);
    }
}
