using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        int Commit();
        IRepository<TSet> GetRepository<TSet>() where TSet : class;
        DbTransaction BeginTransaction();
    }
}
