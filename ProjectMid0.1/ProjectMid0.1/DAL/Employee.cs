using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMid0._1.DAL
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }

        public virtual ICollection<References> Reference { get; set; }

        
    
    }
}
