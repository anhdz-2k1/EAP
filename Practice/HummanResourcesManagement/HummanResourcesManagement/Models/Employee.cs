using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HummanResourcesManagement.Models
{
    public class Employee
    {
        public long EmployeeId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        public string Img { get; set; }

    }
}
