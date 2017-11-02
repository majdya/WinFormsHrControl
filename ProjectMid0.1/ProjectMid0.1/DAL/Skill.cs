using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMid0._1.DAL
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string BriefDescription { get; set; }
        public int EmployeeId { get; set; }


        public virtual Employee Employee { get; set; }

        public virtual ICollection<SkillsInfo> SkillInfo { get; set; }

        public override string ToString()
        {
            string s = string.Format("Skill Name: {0}{2}{1}{2}", SkillName, BriefDescription, Environment.NewLine);
            return s;
        }
    }
}
