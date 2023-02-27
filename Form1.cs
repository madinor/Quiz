using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible=false;
            panel2.Visible=false;
            lblWrong.Visible=false;
        }

        private void comboSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSelectUser.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else if(comboSelectUser.SelectedIndex == 1)
            { 
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowHide.Checked == true)
            {
                txtPassWord.PasswordChar = '\0';
                checkBoxShowHide.Text= "Hide Password";
            }
            else
            {
                txtPassWord.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "cKentucky" && txtPassWord.Text == "cKentucky") 
            {
                lblWrong.Visible = false;
                Teacher teacher = new Teacher();
                teacher.Show();
                this.Hide();
            }
            else 
            {
                lblWrong.Visible = true;
            }
        }
    }
}
