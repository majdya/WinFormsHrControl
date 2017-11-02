using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMid0._1.DAL
{
    public class References
    {
        public int ReferencesId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public int EmployeeId { get; set; }

        public override string ToString()
        {
            return string.Format("{0}   {1}  Position:  {2}  Email: {3}{4}", LastName, FirstName, Position, Email, Environment.NewLine);
        }
        public virtual Employee Employee { get; set; }
    
    }
}
