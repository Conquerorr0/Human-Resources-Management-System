using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AppUsersEmployee : BaseEntity
    {   public string id {  get; set; }     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string department { get; set; }
        public double age { get; set; } 
        public string phone { get; set; }
        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }   
        public string Address { get; set; } 
        public string ChildrenNumber { get; set; }  
        public bool  married { get; set; }
        public string gender { get; set; }  
        public double wage { get; set; }
        public string languageLevel { get; set; }
        //AppUserEmpoyeeProfile
        public virtual AppUserEmployeeProfile EmpoyeeProfile { get; set; }


    }
}
