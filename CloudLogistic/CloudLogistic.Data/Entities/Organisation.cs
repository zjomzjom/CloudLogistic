using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Entities
{
    [Table("Organisation")]
    public class Organisations : BaseModel<int>
    {
        public string Name { get; set; }

        public virtual ICollection<OrganisationsMembers> Members { get; set; }
    }
}
