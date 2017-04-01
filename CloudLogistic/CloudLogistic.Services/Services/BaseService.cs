using CloudLogistic.Data.Entities;
using CloudLogistic.Data.Interfaces;
using CloudLogistic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services.Services
{
    public abstract class BaseService
    {
        protected CLContext _db;
        protected ICacheProvider _cache;
        protected IMapProvider _mapper;
        protected string _cacheKey = "base";

        public BaseService() {
            this._db = null;
            this._cache = null;
            this._mapper = new MapProvider();
        }

        public BaseService(IContext db, ICacheProvider cache)
        {
            this._db = db;
            this._cache = cache;
            this._mapper = new MapProvider();
        }

    }
}
