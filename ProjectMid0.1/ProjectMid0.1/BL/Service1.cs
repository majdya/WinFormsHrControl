using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using ProjectMid0._1.DAL;

namespace ProjectMid0._1.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        static string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

        public void DoWork()
        {
        }


        //#region Get Employees DataTable

        //public static DataTable EmployeesDT()
        //{
        //    DataTable dtEmp = new DataTable();

        //    using (SqlConnection con = new SqlConnection(connString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT LastName, FirstName,Alias,Email FROM Employees", con))
        //        {
        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = cmd.ExecuteReader();
        //                dtEmp.Load(reader);
        //            }
        //            catch (SqlException e)
        //            {
        //                Debug.WriteLine("Error Connecting to  DataBase", e.Message);
        //                MessageBox.Show("Error Connecting to DataBase", "Error");

        //            }

        //        }
        //    }
        //    dtEmp.Columns["LastName"].ColumnName = "Last Name";
        //    dtEmp.Columns["FirstName"].ColumnName = "First Name";
        //    dtEmp.Columns["Alias"].ColumnName = "Alias";
        //    dtEmp.Columns["Email"].ColumnName = "Email";
        //    return dtEmp;
        //}
        //#endregion

        public static DataTable EmployeesDT()
        {
            DataTable dtEmp = new DataTable();
            dtEmp.Columns.Add("EmployeeId");
            dtEmp.Columns.Add("Last Name");
            dtEmp.Columns.Add("First Name");
            dtEmp.Columns.Add("Alias");
            dtEmp.Columns.Add("Email");


            using(ProjectMidDBContext db = new ProjectMidDBContext())
            {
                    List<Employee> empList = new List<Employee>();

                    var q = from emp in db.Employees
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


    }
}
