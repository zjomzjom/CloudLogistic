using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Interfaces
{
    interface IRepository<T>
    {
        IContext Context { get; set; }
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        T FindSingle(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] includes);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] includes);
        IQueryable<T> FindIncluding(params Expression<Func<T, object>>[] includeProperties);
        int Count(Expression<Func<T, bool>> predicate = null);
        bool Exist(Expression<Func<T, bool>> predicate = null);
    }
}
