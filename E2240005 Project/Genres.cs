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
    public partial class Genres : Form
    {
        public Genres()
        {
            InitializeComponent();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddRecords();
            MessageBox.Show("Records Inserted Successfully..!");
            CreateNew();
            ViewGrid();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
        }
        void CreateNew()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedValue = -1;

            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Genre", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            textBox1.Focus();
        }
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Genre_Master]
           ([Genre_id]
           ,[Genre]
           ,[Language])
     VALUES
           ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();

        }
        void ViewGrid()
        {
            Connection conn = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Genre_Master", conn.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Genre_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Genre"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Language"].ToString();
            }

        }
        void UpdateRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE[dbo].[Genre_Master]
            SET [Genre] = '" + textBox2.Text + "',[Language] = '" + comboBox1.Text + "'WHERE [Genre_id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        void DeleteRecords()
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From [Genre_Master] WHERE [Genre_id] = '" + textBox1.Text + "'", connection.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        private void Genres_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }
    }
}
