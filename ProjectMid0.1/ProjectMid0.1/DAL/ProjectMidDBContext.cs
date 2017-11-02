using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProjectMid0._1.DAL
{
    public class ProjectMidDBContext : DbContext
    {
        public ProjectMidDBContext()
            : base("MidDB0.1")
        {
            Database.SetInitializer<ProjectMidDBContext>(new DropCreateDatabaseIfModelChanges<ProjectMidDBContext>());
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Employees Properteis

            modelBuilder.Entity<Employee>().HasKey<int>(emp => emp.EmployeeId);
            modelBuilder.Entity<Employee>().Property(emp => emp.EmployeeId).IsRequired();
            modelBuilder.Entity<Employee>().Property(emp => emp.Email).IsOptional().HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(emp => emp.FirstName).IsOptional().HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(emp => emp.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(emp => emp.Alias).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Employee>().HasMany(emp => emp.Skills);

            #endregion

            #region Skills Properteis

            modelBuilder.Entity<Skill>().HasKey(skl => skl.SkillId); 
            modelBuilder.Entity<Skill>().Property(skl => skl.SkillId).IsRequired();
            modelBuilder.Entity<Skill>().Property(skl => skl.EmployeeId).IsRequired();
            modelBuilder.Entity<Skill>().Property(skl => skl.EmployeeId).IsRequired();
            modelBuilder.Entity<Skill>().Property(skl => skl.SkillName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Skill>().Property(skl => skl.BriefDescription).IsRequired();

            #endregion

            #region Skill Info Properteis

            modelBuilder.Entity<SkillsInfo>().Property(info => info.SkillsInfoId).IsRequired();
            modelBuilder.Entity<SkillsInfo>().Property(info => info.URL).IsRequired().HasMaxLength(250);
            modelBuilder.Entity<SkillsInfo>().Property(info => info.SkillId).IsRequired();

            #endregion

            #region Reference Properteis

            modelBuilder.Entity<References>().HasKey<int>(r => r.ReferencesId);
            modelBuilder.Entity<References>().Property(r => r.LastName).IsRequired().HasMaxLength(50);

            #endregion





  
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillsInfo> SkillInfo { get; set; }
        public DbSet<References> Reference { get; set; }

    }
}
