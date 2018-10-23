﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Enjoygame.DAL.Repositories
{
    interface IRepository<T> where T : class
    {

        IList<T> GetAll();
        IList<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        void Update(T item);
        void Delete(T item);
        void Delete(int itemID);
        T Get(int itemID);
        T Get(string itemName);
    }
}
