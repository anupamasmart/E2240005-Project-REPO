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

namespace E2240005_Project
{
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddRecords();
            MessageBox.Show("Records Inserted Successfully..!");
            CreateNew();
            ViewGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Plan_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNew();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            ViewGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecords();
            ViewGrid();
        }
        void CreateNew()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;

            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Plan", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            textBox1.Focus();
        }
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Plan_Master]
           ([Plan_id]
           ,[Plan_Name]
           ,[Plan_Doc]
           ,[Plan_Book_Limit]
           ,[Plan_Book_Hold]
           ,[Plan_Validity]
           ,[Plan_Amount]
           ,[Plan_Dis]
           ,[Plan_Status])
     VALUES
           ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void ViewGrid()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Plan_Master", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Plan_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Plan_Name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Plan_Doc"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Plan_Book_Limit"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Plan_Book_Hold"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["Plan_Validity"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["Plan_Amount"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["Plan_Dis"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["Plan_Status"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.Rows[n].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[9].Value.ToString();
        }
        void UpdateRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Plan_Master]
            SET [Plan_Name] = '" + textBox2.Text + "',[Plan_Doc] = '" + dateTimePicker1.Text + "',[Plan_Book_Limit] = '" + textBox3.Text + "',[Plan_Book_Hold] = '" + textBox4.Text + "',[Plan_Validity] = '" + textBox5.Text + "',[Plan_Amount] = '" + textBox6.Text + "',[Plan_Dis] = '" + textBox7.Text + "',[Plan_Status] = '" + comboBox1.Text + "'WHERE [Plan_id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From [Plan_Master]  WHERE [Plan_id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
    }
}
