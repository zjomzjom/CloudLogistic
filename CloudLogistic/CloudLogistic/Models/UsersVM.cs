using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudLogistic.Models
{
    public class UsersVM
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }
    }
}