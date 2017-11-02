using ProjectMid0._1.BL;
using ProjectMid0._1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectMid0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            btnFillDB.Visible = !functions.isUp();
        }

        #region Create Database

        private void btnFillDB_Click(object sender, EventArgs e)
        {

            CreateDBFill();
            btnRefresh_Click(sender, e);
        }

        private void CreateDBFill()
        {

            using (ProjectMidDBContext db = new ProjectMidDBContext())
            {

                MessageBox.Show("Creating DataBase", "I'm Working");
                {
                    //Fills The database
                    fill(db);
                    db.SaveChanges();
                }
                MessageBox.Show("You got Your Database", "Im Done!!");
                btnFillDB.Visible = !functions.isUp();
            }
        }

        private void fill(ProjectMidDBContext db)
        {

            for (int i = 1; i < 15; i++)
            {

                Employee empObj = new Employee()
                {
                    FirstName = "First Name " + i,
                    LastName = "Last Name " + i,
                    Alias = "Alias " + i,
                    Email = "e@ma.il " + i
                };
                db.Employees.Add(empObj);

                References refObj = new References()
                {
                    FirstName = "First Name " + i,
                    LastName = "Last Name" + i,
                    Position = "Position" + i,
                    Alias = "Alias" + i,
                    Email = "Email" + i,
                };
                db.Reference.Add(refObj);
                {
                    Skill skillObj = new Skill()
                    {
                        SkillName = "Skill Name" + i,
                        BriefDescription = "BriefDescription " + i,
                        EmployeeId = empObj.EmployeeId,
                    };
                    db.Skills.Add(skillObj);

                    SkillsInfo skillInfoObj = new SkillsInfo()
                    {
                        URL = string.Format("www.ULR{0}.test", i),
                        SkillId = i
                    };
                    db.SkillInfo.Add(skillInfoObj);
                    saveDB(db);

                }
            }
        }
        #endregion

        #region Save Database

        public static void saveDB(ProjectMidDBContext db)
        {

            try
            {
                db.SaveChanges();

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
            }
        }
        #endregion

        #region Open URLs
        public System.Diagnostics.Process p = new System.Diagnostics.Process();

        private void richTextBox1_LinkClicked(object sender,
                             System.Windows.Forms.LinkClickedEventArgs e)
        {
            // Call Process.Start method to open a browser  
            // with link text as URL.  
            p = System.Diagnostics.Process.Start("Chrome.exe", e.LinkText);
        }
        #endregion

        #region refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        #endregion

        #region 1,2 Load the Data to the Grid View
        private void Form1_Load(object sender, EventArgs e)
        {

            if (functions.isUp())
            {

                dgvEmployees.DataSource = Service1.EmployeesDT();
                this.dgvEmployees.Columns[0].Visible = false;

                dgvSkills.DataSource = functions.SkillsDT();
                this.dgvSkills.Columns[0].Visible = false;
            }
        }

        #endregion

        #region 3 Update the Skill/Reference and the data grid view for employyes and skills
        //for Skills and Refrences
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int empId = dgvEmployees.CurrentCell.RowIndex;
                empId = int.Parse(dgvEmployees.CurrentRow.Cells["employeeId"].Value.ToString());
                txtSkillRef.Text = functions.showReferenceData(empId);

                dgvSkills.DataSource = functions.SkillsDT(empId);
                this.dgvSkills.Columns[0].Visible = false;
            }
        }

        //For Employees

        private void dgvSkills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int sklId = dgvSkills.CurrentCell.RowIndex;
                sklId = int.Parse(dgvSkills.CurrentRow.Cells["skillId"].Value.ToString());

                dgvEmployees.DataSource = functions.EmployeeDT(sklId);
                this.dgvEmployees.Columns[0].Visible = false;
            }
        }
        #endregion

        #region 4,5,6 TextBox for Search , Search button , Clear button

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = functions.searchEmp(txtSearch.Text);
            dgvSkills.DataSource = functions.searchSkill(txtSearch.Text);
            if (txtSearch.Text == "")
                btnRefresh_Click(sender, e);
        }
        //Search when press Enter
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }
        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            btnRefresh_Click(sender, e);
        }
        #endregion

        #region 7,8 Add New Skill Information for a sellected employee
        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            int sklId = dgvSkills.CurrentCell.RowIndex;
            sklId = int.Parse(dgvSkills.CurrentRow.Cells["SkillId"].Value.ToString());
            functions.addInfo(txtAddInfo.Text, sklId);

            txtAddInfo.Clear();
            btnRefresh_Click(sender, e);
            txtSkillRef.Refresh();
        }
        #endregion

        #region 9. Add new Employee
        private void btnSubEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = txtEmpFN.Text;
            emp.LastName = txtEmpLN.Text;
            emp.Alias = txtEmpAlias.Text;
            emp.Email = txtEmpEmail.Text;
            functions.AddEmp(emp);

            txtEmpFN.Clear();
            txtEmpLN.Clear();
            txtEmpAlias.Clear();
            txtEmpEmail.Clear();
            btnRefresh_Click(sender, e);
        }
        #endregion

        #region 10. Add new Skill For Selected Employee
        private void btnSubSkill_Click(object sender, EventArgs e)
        {
            //create a skill from the giving data
            Skill skl = new Skill();
            skl.BriefDescription = txtBrief.Text;
            skl.SkillName = txtSkillName.Text;
            //get the id of the selected employee and calls the add function
            int empId = dgvEmployees.CurrentCell.RowIndex;
            empId = int.Parse(dgvEmployees.CurrentRow.Cells["EmployeeId"].Value.ToString());
            functions.AddSkill(skl, empId);

            txtBrief.Clear();
            txtSkillName.Clear();
            btnRefresh_Click(sender, e);
        }
        #endregion

        #region 11. Add new Refrence for sellected Employee
        private void btnSubRef_Click(object sender, EventArgs e)
        {
            References refObj = new References();
            refObj.FirstName = txtRefFN.Text;
            refObj.LastName = txtRefLN.Text;
            refObj.Position = txtRefPos.Text;
            refObj.Email = txtRefEmail.Text;

            int empId = dgvEmployees.CurrentCell.RowIndex;
            empId = int.Parse(dgvEmployees.CurrentRow.Cells["employeeId"].Value.ToString());

            functions.addRef(refObj, empId);
            txtRefFN.Clear();
            txtRefLN.Clear();
            txtRefPos.Clear();
            txtRefEmail.Clear();
            btnRefresh_Click(sender, e);
            txtSkillRef.Refresh();
        }
        #endregion

        #region 12. Close the Software
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int empId = dgvEmployees.CurrentCell.RowIndex;
            empId = int.Parse(dgvEmployees.CurrentRow.Cells["employeeId"].Value.ToString());

            string message = "Are you sure you want to DELETE this Employee?";
            string caption = "Deleteing Employee...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                functions.DeleteEmp(empId);
                btnRefresh_Click(sender, e);
            }
        }
        #endregion
    }
}
