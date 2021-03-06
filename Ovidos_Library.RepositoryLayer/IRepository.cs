﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovidos_Library.RepositoryLayer
{
    public interface IRepository<T> where T : class
    {
        void AddEntity(T entity);
        void UpdateEntity(T entity);
    }
}
