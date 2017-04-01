using CloudLogistic.Data.Entities;
using CloudLogistic.Models;
using CloudLogistic.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services.Interfaces
{
    public interface IOrganisationsService
    {
        ICollection<Organisations> List(bool sorted = false);

        ICollection<OrganisationsVM> ListVM(bool sorted = false);

        Organisations Get(int Id);

        OrganisationsVM GetVM(int Id);

        Organisations Set(OrganisationsVM organisation);

        bool AddUser(int organisationId, int userId);

        bool AddUsersList(int organisationId, ICollection<UsersVM> users);
    }
}
