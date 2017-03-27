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

        T Set(T entity);
        void Remove(T entity);

        ICollection<T> All(bool sorted = false);

        //T FindSingle(Object id);
        /*
        IQueryable<T> Find(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] includes);
        IQueryable<T> FindIncluding(params Expression<Func<T, object>>[] includeProperties);
        int Count(Expression<Func<T, bool>> predicate = null);
        bool Exist(Expression<Func<T, bool>> predicate = null);*/
    }
}
