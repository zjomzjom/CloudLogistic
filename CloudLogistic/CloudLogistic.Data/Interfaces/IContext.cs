using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Interfaces
{
    interface IContext : IDisposable
    {
        IDbSet<T> GetEntitySet<T>() where T : class;
        void ChangeState<T>(T entity, EntityState state) where T : class;
        DbTransaction BeginTransaction();
        int Commit();
    }
}
