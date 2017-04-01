using CloudLogistic.Data.Entities;
using CloudLogistic.Models;
using CloudLogistic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services
{
    public class MapProvider : IMapProvider
    {
        public Users usersVMToUsers(UsersVM user)
        {
            return new Users() {
                Id=user.Id,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
            };
        }


        public UsersVM usersToUserVM(Users user)
        {
            return new UsersVM() {
                Id = user.Id,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                Email = user.User.Email
            };
        }

        public OrganisationsVM organisationsToOrganisationsVM(Organisations organisation)
        {
            return new OrganisationsVM()
            {
                Id = organisation.Id,
                Name = organisation.Name
            };
        }

        public Organisations organisationsVMToOrganisations(OrganisationsVM organisation)
        {
            return new Organisations()
            {
                Id = organisation.Id,
                Name = organisation.Name
            };
        }
        
    }
}
