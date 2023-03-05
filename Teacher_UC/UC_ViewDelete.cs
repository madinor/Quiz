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
    public partial class UC_ViewDelete : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_ViewDelete()
        {
            InitializeComponent();
        }

        private void UC_ViewDelete_Load(object sender, EventArgs e)
        {
            comboSet.Items.Clear();
            comboSet.Items.Add("All Question");
            query = "select distinct qSet from questions";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSet.SelectedIndex != 0)
            {
                query = "select id,qNo,question,optionA,optionB,optionC,optionD,ans from questions where qSet = '"+comboSet.Text+"'";
                DataSet ds = fn.getData(query);
                DataGridView1.DataSource = ds.Tables[0];

            }
            else 
            {
                query = "select id,qNo,question,optionA,optionB,optionC,optionD,ans from questions";
                DataSet ds =fn.getData(query);
                DataGridView1.DataSource= ds.Tables[0];

            }

        }
        int id, questionNo;


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                questionNo = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

            }
            catch 
            {

                
            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?","Delete Confirmation!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                query = "delete from questions where id = '"+ id +"' and qNo = '"+ questionNo +"'";
                fn.setData(query,"Question Deleted.");
                UC_ViewDelete_Load(this,null);

            }

        }
    }
}
