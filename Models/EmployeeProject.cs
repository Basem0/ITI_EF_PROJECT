using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Models
{
    internal class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public string Role { get; set; }

        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
