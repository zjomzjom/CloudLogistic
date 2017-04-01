using CloudLogistic.Data.Entities;
using CloudLogistic.Models;
using CloudLogistic.Services.Extensions;
using CloudLogistic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Services
{
    public class OrganisationsService : BaseService, IOrganisationsService
    {
        public ICollection<Organisations> List(bool sorted = false)
        {
            ICollection<Organisations> organisationsCollection;
            if (sorted)
            {
                organisationsCollection = this._db.Organisations.ToList();
            }
            else
            {
                organisationsCollection = this._db.Organisations.ToHashSet<Organisations>();
            }
            return organisationsCollection;
        }

        public ICollection<OrganisationsVM> ListVM(bool sorted = false)
        {
            ICollection<OrganisationsVM> organisationsCollection;
            ICollection<Organisations> organisationsList = this.List();
            if (sorted)
            {
                organisationsCollection = organisationsList.Select(x => this._mapper.organisationsToOrganisationsVM(x)).ToList();
            }
            else
            {
                organisationsCollection = organisationsList.Select(x => this._mapper.organisationsToOrganisationsVM(x)).ToHashSet();
            }
            return organisationsCollection;
        }

        public Organisations Set(OrganisationsVM organisation)
        {
            return new Organisations();
        }

        public Organisations Get(int Id)
        {
            return this._db.Organisations.FirstOrDefault(x=>x.Id==Id);
        }

        public OrganisationsVM GetVM(int Id)
        {
            Organisations org = this._db.Organisations.FirstOrDefault(x => x.Id == Id);
            return this._mapper.organisationsToOrganisationsVM(org);
        }

        public bool AddUser(int organisationId, int userId)
        {

            return true;
        }

        public bool AddUsersList(int organisationId, ICollection<UsersVM> users)
        {
            return true;
        }
    }
}
