﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Entities
{
    [Table("Users")]
    public class Users : BaseModel<int>
    {
        [ForeignKey("User")]
        public virtual string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }
    }
}
