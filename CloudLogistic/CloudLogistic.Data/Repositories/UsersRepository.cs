using CloudLogistic.Data.Entities;
using CloudLogistic.Data.Extensions;
using CloudLogistic.Data.Interfaces;
using CloudLogistic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Repositories
{
    public class UsersRepository : BaseRepository, IUsersRepository
    {

        public Users Set(Users user)
        {
            if (user == null)
                throw new ArgumentNullException("User", "Model can not be empty");

            Users dbCurrentUser = this._db.Value.Users.FirstOrDefault(x=>x.UserId == user.UserId);
            if (dbCurrentUser == null)
            {
                dbCurrentUser = user;
                this._db.Value.MarkAdded(dbCurrentUser);
            }else
            {
                dbCurrentUser.FirstName = user.FirstName;
                dbCurrentUser.SecondName = user.SecondName;
                this._db.Value.MarkUpdated(dbCurrentUser);
            }
            this._db.Value.Commit();
            return dbCurrentUser;
        }

        public void Remove(Users user)
        {
            
        }


        public Users FindSingle(string id)
        {
            return this._db.Value.Users.FirstOrDefault(x=>x.UserId == id);
        }

        public Users FindSingleByEmail(string email)
        {
            return this._db.Value.Users.FirstOrDefault(x => x.User.Email == email);
        }

        public ICollection<Users> All(bool sorted=false)
        {
            ICollection<Users> collection;
            if (sorted)
                collection = this._db.Value.Users.ToList();
            else
                collection = this._db.Value.Users.ToHashSet();
            return collection;
        }

        public ICollection<AspNetUsers> AllIdentityUsers(bool sorted = false)
        {
            ICollection<AspNetUsers> collection;
            if (sorted)
                collection = this._db.Value.AspNetUsers.ToList();
            else
                collection = this._db.Value.AspNetUsers.ToHashSet();
            return collection;
        }
    }
}
