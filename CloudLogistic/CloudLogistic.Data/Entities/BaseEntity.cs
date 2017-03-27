using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CloudLogistic.Data.Entities
{
    [DataContract]
    public class BaseModel<T>
    {
        [Key]
        [DataMember]
        public T Id { get; set; }
    }
}
