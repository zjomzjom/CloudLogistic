using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Entities
{
    [Table("OrganisationMembers")]
    public class OrganisationsMembers : BaseModel<int>
    {
        public int OrganisationId { get; set; }
        public int UserId { get; set; }
        public string RoleId { get; set; }

        [ForeignKey("OrganisationId")]
        public virtual Organisations Organisation { get; set; }
        [ForeignKey("UserId")]
        public virtual Users Member { get; set; }
        [ForeignKey("RoleId")]
        public virtual AspNetRoles Role { get; set; }
    }
}
