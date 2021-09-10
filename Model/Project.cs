using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
   // [DataContract]
    public class Project
    {
       // [DataMember(Name = "Id")]
        public int Id { get; set; }

       // [DataMember(Name = "Country")]
        public string Country { get; set; }

       // [DataMember(Name = "State")]
        public string State { get; set; }
    }
}
