using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using ProjectMid0._1.DAL;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjectMid0._1.BL
{
    class functions
    {
        static string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

        #region Is Up
        public static bool isUp()
        {
            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                try
                {
                    return db.Database.Exists();
                }
                catch
                {
                    return false;
                }
            }
        }
        #endregion

        #region Save Database

        public static bool saveDB(ProjectMidDBContext db)
        {

            try
            {
                db.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult item in ex.EntityValidationErrors)
                {
                    DbEntityEntry entry = item.Entry;
                    string enttityTypeName = entry.Entity.GetType().Name;
                    foreach (DbValidationError subItem in item.ValidationErrors)
                    {
                        string msg = string.Format
                            ("Error:'{0}' Occurd in {1} at {1}",
                            subItem.ErrorMessage, enttityTypeName, subItem.PropertyName);
                        Debug.WriteLine(msg);
                    }
                }
                MessageBox.Show("Could not save database ", "error");
                return false;
            }
        }
        #endregion

        #region SkillsDT(): Fill all the Skills from the database to the grid

        public static DataTable SkillsDT()
        {
            DataTable sklDT = new DataTable();
            sklDT.Columns.Add("SkillId");
            sklDT.Columns.Add("Skill  Name");
            sklDT.Columns.Add("Brief  Description");

            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                List<Skill> empList = new List<Skill>();
                var q = from skl in db.Skills
                        select skl;

                foreach (Skill skl in q)
                {
                    var row = sklDT.NewRow();
                    row["SkillId"] = skl.SkillId;
                    row["Skill  Name"] = skl.SkillName;
                    row["Brief  Description"] = skl.BriefDescription;
                    sklDT.Rows.Add(row);
                }
            }
            return sklDT;

        }
        #endregion`

        #region SkillsDT(int): gets all the Skills for Sellected Employee

        public static DataTable SkillsDT(int empId)
        {
            DataTable sklDT = new DataTable();
            sklDT.Columns.Add("SkillId");
            sklDT.Columns.Add("Skill  Name");
            sklDT.Columns.Add("Brief  Description");

            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                List<Skill> empList = new List<Skill>();
                var q = from skl in db.Skills
                        where skl.EmployeeId == empId
                        select skl;

                foreach (Skill skl in q)
                {
                    var row = sklDT.NewRow();
                    row["SkillId"] = skl.SkillId;
                    row["Skill  Name"] = skl.SkillName;
                    row["Brief  Description"] = skl.BriefDescription;
                    sklDT.Rows.Add(row);
                }
            }
            return sklDT;
        }
        #endregion

        #region EmployeeDT(int) get a list of the employee that have the selected skill

        public static DataTable EmployeeDT(int sklId)
        {
            DataTable dtEmp = new DataTable();
            dtEmp.Columns.Add("EmployeeId");
            dtEmp.Columns.Add("Last Name");
            dtEmp.Columns.Add("First Name");
            dtEmp.Columns.Add("Alias");
            dtEmp.Columns.Add("Email");


            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                string name = db.Skills.ToList().Find(s => s.SkillId == sklId).SkillName;
                List<Employee> empList = new List<Employee>();

                var q = from emp in db.Employees
                        where emp.Skills.ToList().Any(s => s.SkillName.Equals(name))
                        select emp;



                foreach (Employee emp in q)
                {
                    var row = dtEmp.NewRow();
                    row["EmployeeId"] = emp.EmployeeId;
                    row["Last Name"] = emp.LastName;
                    row["First Name"] = emp.FirstName;
                    row["Alias"] = emp.Alias;
                    row["Email"] = emp.Email;
                    dtEmp.Rows.Add(row);
                }
                return dtEmp;
            }
        }

        #endregion

        #region showReferenceData(int id ) : Return the skills and the refrence for selected employee

        public static string showReferenceData(int empId)
        {
            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                string S = "No Skills found", Si = "No Skill information found", R = "No References found";
                try
                {
                    S = null;
                    Si = null;
                    R = null;
                    var s = db.Skills.ToList().FindAll(s1 => s1.EmployeeId == empId);

                    foreach (var s1 in s)
                    {
                        if (S == null) { S = s1.ToString(); }
                        else
                            S = string.Format("{0}{1}{2}", S, Environment.NewLine, s1.ToString());

                        var si = db.SkillInfo.ToList().FindAll(si1 => si1.SkillId == s1.SkillId);
                        foreach (var si2 in si)
                        {
                            if (Si == null) { Si = si2.ToString(); }
                            else
                                Si = string.Format("{0}{1}{2}", R, Environment.NewLine, si2.ToString());
                        }
                    }


                    var r = db.Reference.ToList().FindAll(r1 => r1.EmployeeId == empId);

                    foreach (var re in r)
                    {
                        if (R == null) { R = re.ToString(); }
                        else
                            R = string.Format("{0}{1}{2}", R, Environment.NewLine, re.ToString());
                    }

                }
                catch { }
                return string.Format("{0}{3}{1}{3}{2}", S, Si, R, Environment.NewLine);
            }
            //return null;
        }

        #endregion

        #region AddEmp(employee) : Add new Employee

        public static bool AddEmp(Employee emp)
        {
            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                db.Employees.Add(emp);
                return saveDB(db);
            }


        }
        #endregion

        #region Search for Employee By Id
        public static DataTable searchEmp(string s)
        {
            DataTable empDT = new DataTable();
            empDT.Columns.Add("EmployeeId");
            empDT.Columns.Add("Last Name");
            empDT.Columns.Add("First Name");
            empDT.Columns.Add("Alias");
            empDT.Columns.Add("Email");

            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                List<Employee> empList = new List<Employee>();
                var q = from emp in db.Employees
                        where emp.LastName.Equals(s) || emp.FirstName.Equals(s)
                        select emp;

                foreach (Employee emp in q)
                {
                    var row = empDT.NewRow();
                    row["EmployeeId"] = emp.EmployeeId;
                    row["Last Name"] = emp.LastName;
                    row["First Name"] = emp.FirstName;
                    row["Alias"] = emp.Alias;
                    row["Email"] = emp.Email;
                    empDT.Rows.Add(row);
                }
            }

            return empDT;
        }

        #endregion

        #region Search for Skill

        public static DataTable searchSkill(string s)
        {
            DataTable sklDT = new DataTable();
            sklDT.Columns.Add("SkillId");
            sklDT.Columns.Add("Skill  Name");
            sklDT.Columns.Add("Brief  Description");


            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                List<Skill> empList = new List<Skill>();
                var q = from skl in db.Skills
                        where skl.SkillName.Equals(s)
                        select skl;

                foreach (Skill skl in q)
                {
                    var row = sklDT.NewRow();
                    row["SkillId"] = skl.SkillId;
                    row["Skill  Name"] = skl.SkillName;
                    row["Brief  Description"] = skl.BriefDescription;
                    sklDT.Rows.Add(row);
                }
            }

            return sklDT;
        }
        #endregion

        #region AddSkill(skill,id): add new Skill
        public static bool AddSkill(Skill skl, int id)
        {
            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                Employee emp = (Employee)db.Employees.ToList().Find(e1 => e1.EmployeeId == id);
                emp.Skills.Add(skl);

                return saveDB(db);
            }


        }
        #endregion

        #region addInfo(stind , empid)add Skill Info
        public static void addInfo(string s, int id)
        {
            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                Skill skl = db.Skills.ToList().Find(skl1 => skl1.SkillId == id);
                SkillsInfo temp = new SkillsInfo();
                temp.URL = s;
                skl.SkillInfo.Add(temp);
                saveDB(db);
            }
        }
        #endregion

        #region addRef(Refrence , empId): addsNew Refrence
        internal static void addRef(References refObj, int empId)
        {
            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {
                Employee emp = db.Employees.First(e => e.EmployeeId == empId);
                emp.Reference.Add(refObj);
                saveDB(db);
            }
        }
        #endregion

        #region Delete(int id) : delete employee by ID
        public static void DeleteEmp(int empId)
        {

                using (ProjectMidDBContext db = new ProjectMidDBContext())
                {

                    List<Skill> sklList = db.Skills.Where(s => s.EmployeeId == empId).ToList();
                    foreach (Skill s in sklList)
                    {
                        List<SkillsInfo> infoList = db.SkillInfo.ToList().Where(i => i.SkillId == s.SkillId).ToList();
                        foreach (SkillsInfo si in infoList)
                        {
                            db.SkillInfo.Remove(si);
                        }
                        db.Skills.Remove(s);
                    }
                    Employee emp = db.Employees.ToList().Find(e => e.EmployeeId == empId);
                    db.Employees.Remove(emp);
                    saveDB(db);
                }
            }
        #endregion
    }
}
