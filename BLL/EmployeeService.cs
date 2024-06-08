using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Entities;

namespace BLL
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _repository;

        public EmployeeService()
        {
            _repository = new EmployeeRepository();
        }

        public List<AppUsersEmployee> GetFilteredEmployees(FilterCriteria criteria)
        {
            return _repository.GetEmployees(criteria);
        }
    }

}
