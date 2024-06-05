using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.Options
{
    public class AppUserEmbloyeeMap:BaseMap<AppUsersEmployee>
    {
        public AppUserEmbloyeeMap() { 
            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("");
            Property(x => x.FirstName).HasColumnName("First Name").IsRequired();
            Property(x => x.LastName).HasColumnName("Last Name").IsRequired();
            Property(x => x.age).HasColumnName("Age").IsRequired().HasColumnType("TINYINT");
            Property(x => x.email).IsRequired().HasColumnName("email").IsRequired(); 
        }
    }
}
