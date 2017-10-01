using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcCoreTest2.Models
{
    public class PersonModel
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
