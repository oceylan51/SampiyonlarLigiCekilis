﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface IRepositoryService<Entity>
    {
        List<Entity> GetAll();
        Entity GetById(int id);

        void Create(Entity entity);
    }
}
