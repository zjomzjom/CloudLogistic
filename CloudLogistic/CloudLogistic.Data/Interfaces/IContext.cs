using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Interfaces
{
    public interface IContext
    {
        /// <summary>
        /// Commit changes to database.
        /// </summary>
        void Commit();

        /// <summary>
        /// Specifies wheter the entity must be update.
        /// </summary>
        /// <typeparam name="T">Entity</typeparam>
        /// <param name="entity"></param>
        void MarkUpdated<T>(T entity) where T : class;


        /// <summary>
        /// Specifies wheter the entity must be delete.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void MarkDeleted<T>(T entity) where T : class;

        /// <summary>
        /// Specifies wheter the entity must be add.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void MarkAdded<T>(T entity) where T : class;
    }
}
