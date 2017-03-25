using CloudLogistic.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data
{
    class UnitOfWork : IUnitOfWork
    {
        private Lazy<IContext> _context;
    }
}
