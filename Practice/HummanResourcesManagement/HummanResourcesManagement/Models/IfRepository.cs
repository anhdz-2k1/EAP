using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HummanResourcesManagement.Models
{
    public interface IfRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
