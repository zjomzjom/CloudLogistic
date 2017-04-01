using CloudLogistic.Data.Entities;
using CloudLogistic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services.Interfaces
{
    public interface IUsersService
    {
        /// <summary>
        /// Get list of all users
        /// </summary>
        /// <param name="sorted"></param>
        /// <returns></returns>
        ICollection<Users> List(bool sorted=false);

        /// <summary>
        /// Get list of all users as viewmodel
        /// </summary>
        /// <param name="sorted"></param>
        /// <returns></returns>
        ICollection<UsersVM> ListVM(bool sorted=false);

        /// <summary>
        /// Update or add user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Users Set(UsersVM user);

        /// <summary>
        /// Get User
        /// </summary>
        /// <param name="Id">User id</param>
        /// <param name="UserId">Identity id</param>
        /// <param name="Email">User Email</param>
        /// <returns></returns>
        Users Get(int? Id, string UserId, string Email);

        /// <summary>
        /// Get UserViewModel
        /// </summary>
        /// <param name="Id">User Id</param>
        /// <param name="Email">User Email</param>
        /// <returns></returns>
        UsersVM GetVM(int? Id, string Email);
    }
}
