﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    public partial class frmRegister : MetroFramework.Forms.MetroForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();
        /*
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= 0x200;
                return myCp;
            }
        }*/

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string teachStatus = "";
            string gender = "";

            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtAddress.Text != "" &&
                txtEmailAddress.Text != "" && txtMobileNumber.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" &&
                txtAnswer1.Text != "" && txtAnswer2.Text != "" && txtAnswer3.Text != "" && txtAnswer4.Text != "" && txtAnswer5.Text != "")
            {
                if (!(rdoFemale.Checked == false && rdoMale.Checked == false))
                {
                    gender = (rdoMale.Checked == true) ? "Male" : "Female";
                    if (!(rdoFulltimer.Checked == false && rdoParttimer.Checked == false && rdoRetiree.Checked == false))
                    {
                        if (rdoFulltimer.Checked == true)
                            teachStatus = "Fulltimer";
                        if (rdoParttimer.Checked == true)
                            teachStatus = "Parttimer";
                        if (rdoRetiree.Checked == true)
                            teachStatus = "Retiree";
                        md.RegisterUser(txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, gender, teachStatus, "cboCourseDe partment.SelectedItem.ToString()", txtEmailAddress.Text, txtMobileNumber.Text);

                        md.RegisterSecurityQuestion(txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtAnswer1.Text, txtAnswer2.Text, txtAnswer3.Text, txtAnswer4.Text, txtAnswer5.Text);
                        frmLogin l = new frmLogin();
                        l.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please select your teaching status", "Teaching Status");
                    }
                }
                else
                {
                    MessageBox.Show("Please select gender", "Gender");
                }
            }
            else
            {
                MessageBox.Show("All Fields are required", "Fields");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void rdoFulltimer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoParttimer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoRetiree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.Show();
            this.Hide();
        }

        private void registerControl1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
