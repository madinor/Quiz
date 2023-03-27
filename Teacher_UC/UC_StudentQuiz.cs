using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.Teacher_UC
{
    public partial class UC_StudentQuiz : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_StudentQuiz()
        {
            InitializeComponent();
        }

        private void UC_StudentQuiz_Load(object sender, EventArgs e)
        {
            hide();
            comboSet.Items.Clear();
            query = "select distinct qset from questions";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            hide();
            btnEnabled();
            btnBorder();
            comboQuestion.Items.Clear();
            query = "select qno from questions where qset = '" + comboSet.Text + "'";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select question,optionA,optionB,optionC,optionD, ans from questions where qset = '" + comboSet.Text + "' and qNo = '" + comboQuestion.Text + "'";
            DataSet ds = fn.getData(query);
            btnEnabled();
            btnBorder();
            show();
            txtQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            btnOption1.Text = ds.Tables[0].Rows[0][1].ToString();
            btnOption2.Text = ds.Tables[0].Rows[0][2].ToString();
            btnOption3.Text = ds.Tables[0].Rows[0][3].ToString();
            btnOption4.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[0][5].ToString();
            lblAnswer.Visible = false;
            txtAnswer.Visible = false;


        }
        public void show() 
        {
            lblQuestion.Visible = true;
            txtQuestion.Visible = true;
            btnOption1.Visible = true;
            btnOption2.Visible = true;
            btnOption3.Visible = true;
            btnOption4.Visible = true;
        }
        public void hide() 
        { 
            lblQuestion.Visible = false;
            txtQuestion.Visible = false;
            btnOption1.Visible = false;
            btnOption2.Visible = false;
            btnOption3.Visible = false;
            btnOption4.Visible = false;
            lblAnswer.Visible = false;
            txtAnswer.Visible = false;

        }
        public void btnBorder() 
        {
            btnOption1.BorderSize = 0;
            btnOption2.BorderSize = 0;
            btnOption3.BorderSize = 0;
            btnOption4.BorderSize = 0;
        }
        public void btnDisabled()
        {
            btnOption1.Enabled= false;
            btnOption2.Enabled= false;
            btnOption3.Enabled= false;
            btnOption4.Enabled= false;
        }

        public void btnEnabled()
        {
            btnOption1.Enabled = true;
            btnOption2.Enabled = true;
            btnOption3.Enabled = true;
            btnOption4.Enabled = true;
        }


        private void btnOption1_Click(object sender, EventArgs e)
        {
            btnDisabled();
            btnOption1.Enabled = true;
            lblAnswer.Visible = true;
            txtAnswer.Visible = true;
            btnOption1.BorderSize = 3;
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            btnDisabled();
            btnOption2.Enabled = true;
            lblAnswer.Visible = true;
            txtAnswer.Visible = true;
            btnOption2.BorderSize = 3;
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            btnDisabled();
            btnOption3.Enabled = true;
            lblAnswer.Visible = true;
            txtAnswer.Visible = true;
            btnOption3.BorderSize = 3;
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            btnDisabled();
            btnOption4.Enabled = true;
            lblAnswer.Visible = true;
            txtAnswer.Visible = true;
            btnOption4.BorderSize = 3;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
