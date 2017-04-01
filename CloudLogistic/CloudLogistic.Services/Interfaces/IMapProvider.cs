using CloudLogistic.Data.Entities;
using CloudLogistic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services.Interfaces
{
    public interface IMapProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Users usersVMToUsers(UsersVM user);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        UsersVM usersToUserVM(Users user);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="organisationVM"></param>
        /// <returns></returns>
        Organisations OrganisationsVMToOrganisations(OrganistationsVM organisationVM);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="organisation"></param>
        /// <returns></returns>
        OrganistationsVM organisationsToOrganisationsVM(Organisations organisation);
    }
}
