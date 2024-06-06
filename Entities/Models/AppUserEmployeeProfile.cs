using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public  class AppUserEmployeeProfile :BaseEntity
    {
        public string userName {  get; set; }   
        public string password { get; set; }
        // AppUsersEmployee ile bire bir bi ilişki kuduk 
        public virtual AppUsersEmployee AppUsersEmployee { get; set; }
    }
}
