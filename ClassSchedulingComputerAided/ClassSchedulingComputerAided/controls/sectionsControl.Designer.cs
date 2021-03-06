﻿namespace ClassSchedulingComputerAided
{
    partial class sectionsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvShowSections = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cboSelectYear = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboSelectCourse = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNumberOfSection = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboCourseDepartment = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSections)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.dgvShowSections);
            this.groupBox3.Location = new System.Drawing.Point(40, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 390);
            this.groupBox3.TabIndex = 190;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Sections";
            // 
            // dgvShowSections
            // 
            this.dgvShowSections.AllowUserToAddRows = false;
            this.dgvShowSections.AllowUserToDeleteRows = false;
            this.dgvShowSections.AllowUserToResizeColumns = false;
            this.dgvShowSections.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvShowSections.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowSections.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvShowSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowSections.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowSections.Location = new System.Drawing.Point(6, 16);
            this.dgvShowSections.MultiSelect = false;
            this.dgvShowSections.Name = "dgvShowSections";
            this.dgvShowSections.ReadOnly = true;
            this.dgvShowSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowSections.Size = new System.Drawing.Size(284, 374);
            this.dgvShowSections.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.cboSelectYear);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cboSelectCourse);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtNumberOfSection);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(342, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 114);
            this.groupBox1.TabIndex = 189;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Sections";
            // 
            // metroLabel11
            // 
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(26, 17);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(101, 29);
            this.metroLabel11.TabIndex = 175;
            this.metroLabel11.Text = "Select Course:";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSelectYear
            // 
            this.cboSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectYear.FormattingEnabled = true;
            this.cboSelectYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboSelectYear.Location = new System.Drawing.Point(156, 52);
            this.cboSelectYear.Name = "cboSelectYear";
            this.cboSelectYear.Size = new System.Drawing.Size(146, 21);
            this.cboSelectYear.TabIndex = 184;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(26, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 29);
            this.metroLabel1.TabIndex = 177;
            this.metroLabel1.Text = "Select Year:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSelectCourse
            // 
            this.cboSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCourse.FormattingEnabled = true;
            this.cboSelectCourse.Location = new System.Drawing.Point(156, 25);
            this.cboSelectCourse.Name = "cboSelectCourse";
            this.cboSelectCourse.Size = new System.Drawing.Size(146, 21);
            this.cboSelectCourse.TabIndex = 184;
            // 
            // metroLabel3
            // 
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(26, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 25);
            this.metroLabel3.TabIndex = 179;
            this.metroLabel3.Text = "Number of Section:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfSection
            // 
            this.txtNumberOfSection.Location = new System.Drawing.Point(156, 79);
            this.txtNumberOfSection.Multiline = true;
            this.txtNumberOfSection.Name = "txtNumberOfSection";
            this.txtNumberOfSection.Size = new System.Drawing.Size(146, 25);
            this.txtNumberOfSection.TabIndex = 180;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 40);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAdd.TabIndex = 187;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(295, 40);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 188;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.cboCourseDepartment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 39);
            this.panel1.TabIndex = 240;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.CustomBackground = true;
            this.txtUsername.Location = new System.Drawing.Point(96, 9);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 21);
            this.txtUsername.TabIndex = 134;
            // 
            // metroLabel2
            // 
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.Location = new System.Drawing.Point(27, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 21);
            this.metroLabel2.TabIndex = 135;
            this.metroLabel2.Text = "Search:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCourseDepartment
            // 
            this.cboCourseDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseDepartment.FormattingEnabled = true;
            this.cboCourseDepartment.Location = new System.Drawing.Point(246, 9);
            this.cboCourseDepartment.Name = "cboCourseDepartment";
            this.cboCourseDepartment.Size = new System.Drawing.Size(128, 21);
            this.cboCourseDepartment.TabIndex = 236;
            // 
            // sectionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Name = "sectionsControl";
            this.Size = new System.Drawing.Size(700, 451);
            this.Load += new System.EventHandler(this.sectionsControl_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSections)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dgvShowSections;
        public System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroLabel metroLabel11;
        public System.Windows.Forms.ComboBox cboSelectYear;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.ComboBox cboSelectCourse;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox txtNumberOfSection;
        public MetroFramework.Controls.MetroTile btnAdd;
        public MetroFramework.Controls.MetroTile btnDelete;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroTextBox txtUsername;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.ComboBox cboCourseDepartment;
    }
}
