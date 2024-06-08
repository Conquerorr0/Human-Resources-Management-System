using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FilterCriteria
    {
        public string Department { get; set; }
        public int? Age { get; set; }
        public double? Salary { get; set; }
        public bool SalaryLessThanOrEqual { get; set; } // true if filtering by less or equal, false otherwise
        public string LanguageLevel { get; set; }
    }
}
