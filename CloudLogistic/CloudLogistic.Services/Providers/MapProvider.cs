using CloudLogistic.Data.Entities;
using CloudLogistic.Models;
using CloudLogistic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services.Services
{
    public class MapProvider : IMapProvider
    {
        public Users usersVMToUsers(UsersVM user)
        {
            return new Users() {
                UserId = user.UserId,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
            };
        }

        public UsersVM usersToUserVM(Users user)
        {
            return new UserVM() {
                UserId = user.UserId,
                FirstName = user.FirstName,
                SecondName = user.SecondName
            };
        }


    }
}
