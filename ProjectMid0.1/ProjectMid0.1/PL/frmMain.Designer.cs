namespace ProjectMid0._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnFillDB = new System.Windows.Forms.Button();
            this.dgvSkills = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gbEmployees = new System.Windows.Forms.GroupBox();
            this.gbSkills = new System.Windows.Forms.GroupBox();
            this.lblSearchSkill = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbAddInfo = new System.Windows.Forms.GroupBox();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.txtAddInfo = new System.Windows.Forms.TextBox();
            this.lblAddInfo = new System.Windows.Forms.Label();
            this.gbNewEmp = new System.Windows.Forms.GroupBox();
            this.btnSubEmp = new System.Windows.Forms.Button();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpAlias = new System.Windows.Forms.TextBox();
            this.txtEmpLN = new System.Windows.Forms.TextBox();
            this.txtEmpFN = new System.Windows.Forms.TextBox();
            this.lbEmplEmail = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.lblEmpFirstName = new System.Windows.Forms.Label();
            this.lblNewSkill = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.txtBrief = new System.Windows.Forms.TextBox();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.btnSubSkill = new System.Windows.Forms.Button();
            this.gbRef = new System.Windows.Forms.GroupBox();
            this.btnSubRef = new System.Windows.Forms.Button();
            this.txtRefEmail = new System.Windows.Forms.TextBox();
            this.txtRefPos = new System.Windows.Forms.TextBox();
            this.txtRefLN = new System.Windows.Forms.TextBox();
            this.txtRefFN = new System.Windows.Forms.TextBox();
            this.lblRefEmail = new System.Windows.Forms.Label();
            this.lblRefPos = new System.Windows.Forms.Label();
            this.lblRefLN = new System.Windows.Forms.Label();
            this.lblRefFN = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSkillRef = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).BeginInit();
            this.gbEmployees.SuspendLayout();
            this.gbAddInfo.SuspendLayout();
            this.gbNewEmp.SuspendLayout();
            this.lblNewSkill.SuspendLayout();
            this.gbRef.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(6, 19);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(382, 144);
            this.dgvEmployees.TabIndex = 3;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // btnFillDB
            // 
            this.btnFillDB.Location = new System.Drawing.Point(122, 584);
            this.btnFillDB.Name = "btnFillDB";
            this.btnFillDB.Size = new System.Drawing.Size(106, 29);
            this.btnFillDB.TabIndex = 5;
            this.btnFillDB.Text = "Create and Fill";
            this.btnFillDB.UseVisualStyleBackColor = true;
            this.btnFillDB.Click += new System.EventHandler(this.btnFillDB_Click);
            // 
            // dgvSkills
            // 
            this.dgvSkills.AllowUserToAddRows = false;
            this.dgvSkills.AllowUserToDeleteRows = false;
            this.dgvSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkills.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSkills.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSkills.Location = new System.Drawing.Point(18, 198);
            this.dgvSkills.MultiSelect = false;
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.ReadOnly = true;
            this.dgvSkills.Size = new System.Drawing.Size(382, 133);
            this.dgvSkills.TabIndex = 6;
            this.dgvSkills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkills_CellContentClick);
            this.dgvSkills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkills_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(459, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Skills/References";
            // 
            // gbEmployees
            // 
            this.gbEmployees.Controls.Add(this.dgvEmployees);
            this.gbEmployees.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbEmployees.Location = new System.Drawing.Point(12, 12);
            this.gbEmployees.Name = "gbEmployees";
            this.gbEmployees.Size = new System.Drawing.Size(394, 170);
            this.gbEmployees.TabIndex = 10;
            this.gbEmployees.TabStop = false;
            this.gbEmployees.Text = "Employees (Click to select an employee)";
            // 
            // gbSkills
            // 
            this.gbSkills.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbSkills.Location = new System.Drawing.Point(12, 178);
            this.gbSkills.Name = "gbSkills";
            this.gbSkills.Size = new System.Drawing.Size(394, 157);
            this.gbSkills.TabIndex = 11;
            this.gbSkills.TabStop = false;
            this.gbSkills.Text = "Skills (Click to get all skill information)";
            // 
            // lblSearchSkill
            // 
            this.lblSearchSkill.AutoSize = true;
            this.lblSearchSkill.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblSearchSkill.Location = new System.Drawing.Point(27, 368);
            this.lblSearchSkill.Name = "lblSearchSkill";
            this.lblSearchSkill.Size = new System.Drawing.Size(99, 13);
            this.lblSearchSkill.TabIndex = 12;
            this.lblSearchSkill.Text = "Search for skills:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtSearch.Location = new System.Drawing.Point(132, 365);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(341, 19);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "Add keywords separated by a space. Press<Enter> to search";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(404, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 26);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(323, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 26);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbAddInfo
            // 
            this.gbAddInfo.Controls.Add(this.btnAddInfo);
            this.gbAddInfo.Controls.Add(this.txtAddInfo);
            this.gbAddInfo.Controls.Add(this.lblAddInfo);
            this.gbAddInfo.Location = new System.Drawing.Point(479, 341);
            this.gbAddInfo.Name = "gbAddInfo";
            this.gbAddInfo.Size = new System.Drawing.Size(358, 86);
            this.gbAddInfo.TabIndex = 16;
            this.gbAddInfo.TabStop = false;
            this.gbAddInfo.Text = "Add Info to Current Skill";
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(255, 57);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(75, 23);
            this.btnAddInfo.TabIndex = 2;
            this.btnAddInfo.Text = "Submit Info";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // txtAddInfo
            // 
            this.txtAddInfo.Location = new System.Drawing.Point(84, 27);
            this.txtAddInfo.Name = "txtAddInfo";
            this.txtAddInfo.Size = new System.Drawing.Size(246, 20);
            this.txtAddInfo.TabIndex = 1;
            // 
            // lblAddInfo
            // 
            this.lblAddInfo.AutoSize = true;
            this.lblAddInfo.Location = new System.Drawing.Point(6, 30);
            this.lblAddInfo.Name = "lblAddInfo";
            this.lblAddInfo.Size = new System.Drawing.Size(55, 13);
            this.lblAddInfo.TabIndex = 0;
            this.lblAddInfo.Text = "URL/UNC:";
            // 
            // gbNewEmp
            // 
            this.gbNewEmp.Controls.Add(this.btnSubEmp);
            this.gbNewEmp.Controls.Add(this.txtEmpEmail);
            this.gbNewEmp.Controls.Add(this.txtEmpAlias);
            this.gbNewEmp.Controls.Add(this.txtEmpLN);
            this.gbNewEmp.Controls.Add(this.txtEmpFN);
            this.gbNewEmp.Controls.Add(this.lbEmplEmail);
            this.gbNewEmp.Controls.Add(this.lblAlias);
            this.gbNewEmp.Controls.Add(this.lblEmpLastName);
            this.gbNewEmp.Controls.Add(this.lblEmpFirstName);
            this.gbNewEmp.Location = new System.Drawing.Point(18, 433);
            this.gbNewEmp.Name = "gbNewEmp";
            this.gbNewEmp.Size = new System.Drawing.Size(225, 145);
            this.gbNewEmp.TabIndex = 17;
            this.gbNewEmp.TabStop = false;
            this.gbNewEmp.Text = "New Employee";
            // 
            // btnSubEmp
            // 
            this.btnSubEmp.Font = new System.Drawing.Font("Tahoma", 7F);
            this.btnSubEmp.Location = new System.Drawing.Point(110, 110);
            this.btnSubEmp.Name = "btnSubEmp";
            this.btnSubEmp.Size = new System.Drawing.Size(100, 23);
            this.btnSubEmp.TabIndex = 8;
            this.btnSubEmp.Text = "Submit Employee";
            this.btnSubEmp.UseVisualStyleBackColor = true;
            this.btnSubEmp.Click += new System.EventHandler(this.btnSubEmp_Click);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(74, 84);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmpEmail.TabIndex = 7;
            // 
            // txtEmpAlias
            // 
            this.txtEmpAlias.Location = new System.Drawing.Point(74, 59);
            this.txtEmpAlias.Name = "txtEmpAlias";
            this.txtEmpAlias.Size = new System.Drawing.Size(136, 20);
            this.txtEmpAlias.TabIndex = 6;
            // 
            // txtEmpLN
            // 
            this.txtEmpLN.Location = new System.Drawing.Point(74, 36);
            this.txtEmpLN.Name = "txtEmpLN";
            this.txtEmpLN.Size = new System.Drawing.Size(136, 20);
            this.txtEmpLN.TabIndex = 5;
            // 
            // txtEmpFN
            // 
            this.txtEmpFN.Location = new System.Drawing.Point(74, 13);
            this.txtEmpFN.Name = "txtEmpFN";
            this.txtEmpFN.Size = new System.Drawing.Size(136, 20);
            this.txtEmpFN.TabIndex = 4;
            // 
            // lbEmplEmail
            // 
            this.lbEmplEmail.AutoSize = true;
            this.lbEmplEmail.Location = new System.Drawing.Point(6, 87);
            this.lbEmplEmail.Name = "lbEmplEmail";
            this.lbEmplEmail.Size = new System.Drawing.Size(39, 13);
            this.lbEmplEmail.TabIndex = 3;
            this.lbEmplEmail.Text = "E-mail:";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(6, 62);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(33, 13);
            this.lblAlias.TabIndex = 2;
            this.lblAlias.Text = "Alias:";
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.Location = new System.Drawing.Point(6, 39);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(61, 13);
            this.lblEmpLastName.TabIndex = 1;
            this.lblEmpLastName.Text = "Last Name:";
            // 
            // lblEmpFirstName
            // 
            this.lblEmpFirstName.AutoSize = true;
            this.lblEmpFirstName.Location = new System.Drawing.Point(6, 16);
            this.lblEmpFirstName.Name = "lblEmpFirstName";
            this.lblEmpFirstName.Size = new System.Drawing.Size(62, 13);
            this.lblEmpFirstName.TabIndex = 0;
            this.lblEmpFirstName.Text = "First Name:";
            // 
            // lblNewSkill
            // 
            this.lblNewSkill.Controls.Add(this.label3);
            this.lblNewSkill.Controls.Add(this.lblSkillName);
            this.lblNewSkill.Controls.Add(this.txtBrief);
            this.lblNewSkill.Controls.Add(this.txtSkillName);
            this.lblNewSkill.Controls.Add(this.btnSubSkill);
            this.lblNewSkill.Location = new System.Drawing.Point(249, 433);
            this.lblNewSkill.Name = "lblNewSkill";
            this.lblNewSkill.Size = new System.Drawing.Size(250, 145);
            this.lblNewSkill.TabIndex = 0;
            this.lblNewSkill.TabStop = false;
            this.lblNewSkill.Text = "New Skill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Brief Description of Skill:";
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Location = new System.Drawing.Point(6, 20);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(171, 13);
            this.lblSkillName.TabIndex = 12;
            this.lblSkillName.Text = "Short Name of Skill or Technology:";
            // 
            // txtBrief
            // 
            this.txtBrief.Location = new System.Drawing.Point(7, 82);
            this.txtBrief.Name = "txtBrief";
            this.txtBrief.Size = new System.Drawing.Size(217, 20);
            this.txtBrief.TabIndex = 11;
            // 
            // txtSkillName
            // 
            this.txtSkillName.Location = new System.Drawing.Point(9, 36);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(215, 20);
            this.txtSkillName.TabIndex = 10;
            // 
            // btnSubSkill
            // 
            this.btnSubSkill.Font = new System.Drawing.Font("Tahoma", 7F);
            this.btnSubSkill.Location = new System.Drawing.Point(144, 110);
            this.btnSubSkill.Name = "btnSubSkill";
            this.btnSubSkill.Size = new System.Drawing.Size(100, 23);
            this.btnSubSkill.TabIndex = 9;
            this.btnSubSkill.Text = "Submit Skill";
            this.btnSubSkill.UseVisualStyleBackColor = true;
            this.btnSubSkill.Click += new System.EventHandler(this.btnSubSkill_Click);
            // 
            // gbRef
            // 
            this.gbRef.Controls.Add(this.btnSubRef);
            this.gbRef.Controls.Add(this.txtRefEmail);
            this.gbRef.Controls.Add(this.txtRefPos);
            this.gbRef.Controls.Add(this.txtRefLN);
            this.gbRef.Controls.Add(this.txtRefFN);
            this.gbRef.Controls.Add(this.lblRefEmail);
            this.gbRef.Controls.Add(this.lblRefPos);
            this.gbRef.Controls.Add(this.lblRefLN);
            this.gbRef.Controls.Add(this.lblRefFN);
            this.gbRef.Location = new System.Drawing.Point(505, 433);
            this.gbRef.Name = "gbRef";
            this.gbRef.Size = new System.Drawing.Size(331, 145);
            this.gbRef.TabIndex = 0;
            this.gbRef.TabStop = false;
            this.gbRef.Text = "Add Reference Person to Selected Employee:";
            // 
            // btnSubRef
            // 
            this.btnSubRef.Font = new System.Drawing.Font("Tahoma", 7F);
            this.btnSubRef.Location = new System.Drawing.Point(204, 110);
            this.btnSubRef.Name = "btnSubRef";
            this.btnSubRef.Size = new System.Drawing.Size(100, 23);
            this.btnSubRef.TabIndex = 17;
            this.btnSubRef.Text = "Submit Ref";
            this.btnSubRef.UseVisualStyleBackColor = true;
            this.btnSubRef.Click += new System.EventHandler(this.btnSubRef_Click);
            // 
            // txtRefEmail
            // 
            this.txtRefEmail.Location = new System.Drawing.Point(74, 88);
            this.txtRefEmail.Name = "txtRefEmail";
            this.txtRefEmail.Size = new System.Drawing.Size(230, 20);
            this.txtRefEmail.TabIndex = 16;
            // 
            // txtRefPos
            // 
            this.txtRefPos.Location = new System.Drawing.Point(74, 63);
            this.txtRefPos.Name = "txtRefPos";
            this.txtRefPos.Size = new System.Drawing.Size(230, 20);
            this.txtRefPos.TabIndex = 15;
            // 
            // txtRefLN
            // 
            this.txtRefLN.Location = new System.Drawing.Point(74, 40);
            this.txtRefLN.Name = "txtRefLN";
            this.txtRefLN.Size = new System.Drawing.Size(230, 20);
            this.txtRefLN.TabIndex = 14;
            // 
            // txtRefFN
            // 
            this.txtRefFN.Location = new System.Drawing.Point(74, 17);
            this.txtRefFN.Name = "txtRefFN";
            this.txtRefFN.Size = new System.Drawing.Size(230, 20);
            this.txtRefFN.TabIndex = 13;
            // 
            // lblRefEmail
            // 
            this.lblRefEmail.AutoSize = true;
            this.lblRefEmail.Location = new System.Drawing.Point(6, 87);
            this.lblRefEmail.Name = "lblRefEmail";
            this.lblRefEmail.Size = new System.Drawing.Size(39, 13);
            this.lblRefEmail.TabIndex = 12;
            this.lblRefEmail.Text = "E-mail:";
            // 
            // lblRefPos
            // 
            this.lblRefPos.AutoSize = true;
            this.lblRefPos.Location = new System.Drawing.Point(6, 62);
            this.lblRefPos.Name = "lblRefPos";
            this.lblRefPos.Size = new System.Drawing.Size(48, 13);
            this.lblRefPos.TabIndex = 11;
            this.lblRefPos.Text = "Position:";
            // 
            // lblRefLN
            // 
            this.lblRefLN.AutoSize = true;
            this.lblRefLN.Location = new System.Drawing.Point(6, 39);
            this.lblRefLN.Name = "lblRefLN";
            this.lblRefLN.Size = new System.Drawing.Size(61, 13);
            this.lblRefLN.TabIndex = 10;
            this.lblRefLN.Text = "Last Name:";
            // 
            // lblRefFN
            // 
            this.lblRefFN.AutoSize = true;
            this.lblRefFN.Location = new System.Drawing.Point(6, 16);
            this.lblRefFN.Name = "lblRefFN";
            this.lblRefFN.Size = new System.Drawing.Size(62, 13);
            this.lblRefFN.TabIndex = 9;
            this.lblRefFN.Text = "First Name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(18, 582);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 29);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(753, 582);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 29);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSkillRef
            // 
            this.txtSkillRef.Location = new System.Drawing.Point(429, 27);
            this.txtSkillRef.Name = "txtSkillRef";
            this.txtSkillRef.Size = new System.Drawing.Size(407, 304);
            this.txtSkillRef.TabIndex = 20;
            this.txtSkillRef.Text = "";
            this.txtSkillRef.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(663, 584);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 27);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 620);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSkillRef);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblNewSkill);
            this.Controls.Add(this.gbRef);
            this.Controls.Add(this.gbNewEmp);
            this.Controls.Add(this.gbAddInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchSkill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSkills);
            this.Controls.Add(this.btnFillDB);
            this.Controls.Add(this.gbEmployees);
            this.Controls.Add(this.gbSkills);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Name = "Form1";
            this.Text = "HR Skills Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).EndInit();
            this.gbEmployees.ResumeLayout(false);
            this.gbAddInfo.ResumeLayout(false);
            this.gbAddInfo.PerformLayout();
            this.gbNewEmp.ResumeLayout(false);
            this.gbNewEmp.PerformLayout();
            this.lblNewSkill.ResumeLayout(false);
            this.lblNewSkill.PerformLayout();
            this.gbRef.ResumeLayout(false);
            this.gbRef.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnFillDB;
        private System.Windows.Forms.DataGridView dgvSkills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbEmployees;
        private System.Windows.Forms.GroupBox gbSkills;
        private System.Windows.Forms.Label lblSearchSkill;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbAddInfo;
        private System.Windows.Forms.Label lblAddInfo;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.TextBox txtAddInfo;
        private System.Windows.Forms.GroupBox gbNewEmp;
        private System.Windows.Forms.Label lblEmpFirstName;
        private System.Windows.Forms.GroupBox lblNewSkill;
        private System.Windows.Forms.GroupBox gbRef;
        private System.Windows.Forms.Label lbEmplEmail;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.Button btnSubEmp;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpAlias;
        private System.Windows.Forms.TextBox txtEmpLN;
        private System.Windows.Forms.TextBox txtEmpFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.TextBox txtBrief;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.Button btnSubSkill;
        private System.Windows.Forms.Button btnSubRef;
        private System.Windows.Forms.TextBox txtRefEmail;
        private System.Windows.Forms.TextBox txtRefPos;
        private System.Windows.Forms.TextBox txtRefLN;
        private System.Windows.Forms.TextBox txtRefFN;
        private System.Windows.Forms.Label lblRefEmail;
        private System.Windows.Forms.Label lblRefPos;
        private System.Windows.Forms.Label lblRefLN;
        private System.Windows.Forms.Label lblRefFN;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox txtSkillRef;
        private System.Windows.Forms.Button btnDelete;
    }
}

