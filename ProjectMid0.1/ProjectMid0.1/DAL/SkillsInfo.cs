using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMid0._1.DAL
{
    public class SkillsInfo
    {
        public int SkillsInfoId { get; set; }
        public string URL { get; set; }
        public int SkillId { get; set; }

        public virtual Skill Skill { get; set; }

        public override string ToString()
        {
            return  string.Format("Skill Information:{0}"+URL+"{0}",Environment.NewLine);
        }
    }
}
