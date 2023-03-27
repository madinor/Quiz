using Guna.UI.WinForms;
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
    public partial class Teacher : Form
    {
       // public static Teacher instance;
       // public Panel pn;
        
        public Teacher()
        {
            InitializeComponent();
           // instance = this;
           // pn=gPanel1 ;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            uC_Addnewquestion1.Visible= false;
            uc_UpdateQuestion1.Visible= false;
            uC_ViewDelete1.Visible= false;
            uC_StudentQuiz1.Visible= false;
            gPanel1.Visible= false;
            
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            uC_Addnewquestion1.Visible = true;
            uC_Addnewquestion1.BringToFront();

        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            uc_UpdateQuestion1.Visible = true;
            uc_UpdateQuestion1.BringToFront();
        }

        private void btnViewDelete_Click(object sender, EventArgs e)
        {
            uC_ViewDelete1.Visible = true;
            uC_ViewDelete1.BringToFront();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
