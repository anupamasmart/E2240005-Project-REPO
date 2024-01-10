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
    public partial class Rack : Form
    {
        public Rack()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRecords();
            ViewGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            ViewGrid();
        }

        private void button4_Click(object sender, EventArgs e)
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
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Rack", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            textBox1.Focus();
        }
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Rack_Master]
           ([Rack_Id]
           ,[Rack_Name]
           ,[Rack_Status])
     VALUES
           ( '" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void ViewGrid()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Rack_Master", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Rack_Id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Rack_Name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Rack_Status"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
        }
        void UpdateRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Rack_Master]
            SET [Rack_Name] = '" + textBox2.Text + "',[Rack_Status] = '" + comboBox1.Text + "' WHERE [Rack_Id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From [Rack_Master]  WHERE [Rack_Id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        private void Rack_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }
    }
}
