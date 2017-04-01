using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services.Interfaces
{
    public interface ICacheProvider
    {
        /// <summary>
        /// set cache with defatul time
        /// </summary>
        /// <param name="cacheKey">name of key</param>
        /// <param name="value">value</param>
        void SetCache(string cacheKey, object value);

        /// <summary>
        /// set cache
        /// </summary>
        /// <param name="cacheKey">name of key</param>
        /// <param name="value">value</param>
        /// <param name="cacheTime">cache store time (mintues)</param>
        void SetCache(string cacheKey, object value, int cacheTime);

        /// <summary>
        /// remove object from cache
        /// </summary>
        /// <param name="cacheKey">name of key</param>
        void RemoveCache(string cacheKey);

        /// <summary>
        /// remove object from cache
        /// </summary>
        /// <param name="searchString">start of the keys</param>
        void RemoveItemsFromCache(string searchString);

        /// <summary>
        /// return object from cache
        /// </summary>
        /// <param name="cacheKey">name of key</param>
        /// <returns></returns>
        object GetCache(string cacheKey);

        /// <summary>
        /// lists all keys
        /// </summary>
        /// <returns></returns>
        IList<string> GetKeys();

        /// <summary>
        /// clears cache (combines GetKeys and RemoveCache)
        /// </summary>
        void ClearCache();

        /// <summary>
        /// get cache object, if null use func to fill cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cacheKey"></param>
        /// <param name="func"></param>
        /// <param name="slidingMin"></param>
        /// <param name="absoluteMin"></param>
        /// <returns></returns>
        T GetSet<T>(string cacheKey, Func<T> func, double slidingMin = 60, double absoluteMin = 1440);
    }
}
