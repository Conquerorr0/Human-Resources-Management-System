using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepository
    {
        private List<AppUsersEmployee> _employees; // This should be replaced with actual database access.

        public EmployeeRepository()
        {
            // Initialize with some dummy data or fetch from database
            _employees = new List<AppUsersEmployee>();
        }

        public List<AppUsersEmployee> GetEmployees(FilterCriteria criteria)
        {
            var query = _employees.AsQueryable();

            if (criteria.Age.HasValue)
                query = query.Where(e => e.age == criteria.Age.Value);


            if (!string.IsNullOrEmpty(criteria.LanguageLevel))
                query = query.Where(e => e.languageLevel == criteria.LanguageLevel);

            return query.ToList();
        }
    }

}
