using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HummanResourcesManagement.Models
{
    public class EfRepository :  IfRepository
    {
        private EmployeeDBContext context;
        public EfRepository(EmployeeDBContext employeeDBContext)
        {
            context = employeeDBContext;
        }
        public IQueryable<Employee> Employees => context.Employees;
    }
}
