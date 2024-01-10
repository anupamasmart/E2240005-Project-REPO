using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E2240005_Project
{
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            CreateNew();
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            ViewGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddRecords();
            MessageBox.Show("Records Inserted Successfully..!");
            CreateNew();
            ViewGrid();
        }
        void CreateNew()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedValue = -1;

            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Section", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            textBox1.Focus();
        }
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Section_Master]
           ([Sec_Id]
           ,[Sec_Name]
           ,[Sec_Status])
     VALUES
           ( '" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void ViewGrid()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Section_Master", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Sec_Id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Sec_Name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Sec_Status"].ToString();
            }
        }


        void UpdateRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Section_Master]
            SET [Sec_Name] = '" + textBox2.Text + "',[Sec_Status] = '" + comboBox1.Text + "' WHERE [Sec_Id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From [Section_Master]  WHERE [Sec_Id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        private void Section_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecords();
            ViewGrid();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
        }
    }
}
