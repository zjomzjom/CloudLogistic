using CloudLogistic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Models
{
    public abstract class BaseRepository
    {
        protected Lazy<CLContext> _db { get; private set; }
        protected BaseRepository()
        {
            _db = new Lazy<CLContext>(() => new CLContext());
        }
        protected BaseRepository(CLContext ctx)
        {
            _db = new Lazy<CLContext>(() => ctx);
        }
    }
}
