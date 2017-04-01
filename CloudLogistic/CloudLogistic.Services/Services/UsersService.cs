using CloudLogistic.Data.Entities;
using CloudLogistic.Models;
using CloudLogistic.Services;
using CloudLogistic.Services.Interfaces;
using CloudLogistic.Services.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services.Services
{
    public class UsersService : BaseService, IUsersService
    {
        public ICollection<Users> List(bool sorted = false)
        {
            ICollection<Users> usersCollection;
            if (sorted)
            {
                usersCollection = this._db.Users.ToList();
            }
            else
            {
                usersCollection = this._db.Users.ToHashSet<Users>();
            }
            return usersCollection;
        }

        public ICollection<UsersVM> ListVM(bool sorted = false)
        {
            ICollection<UsersVM> usersCollection;
            ICollection<Users> usersList = this.List();
            if (sorted)
            {
                usersCollection = usersList.Select(x => this._mapper.usersToUserVM(x)).ToList();
            }
            else
            {
                usersCollection = usersList.Select(x => this._mapper.usersToUserVM(x)).ToHashSet();
            }
            return usersCollection;
        }

        public Users Set(UsersVM user)
        {
            return new Users();
        }

        public Users Get(int? Id, string UserId, string Email)
        {
            return new Users();
        }

        public UsersVM GetVM(int? Id, string Email)
        {
            return new UsersVM();
        }
    }
}
