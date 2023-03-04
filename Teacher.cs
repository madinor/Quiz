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
        public Teacher()
        {
            InitializeComponent();
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
            
            
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            uC_Addnewquestion1.Visible = true;
            uC_Addnewquestion1.BringToFront();

        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            uc_UpdateQuestion1.Visible= true;
            uc_UpdateQuestion1.BringToFront();

        }
    }
}
