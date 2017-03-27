using CloudLogistic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Interfaces
{
    interface IUsersRepository : IRepository<Users>
    {
        /// <summary>
        /// Find user by email
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Users FindSingleByEmail(string email);
    }
}
