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
    public partial class Book_Master : Form
    {
        public Book_Master()
        {
            InitializeComponent();
        }

        private void Book_Master_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
            fillcombo1();
            fillcombo2();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddRecords();
            MessageBox.Show("Records Inserted Successfully..!");
            CreateNew();
            ViewGrid();
        }
        private void fillcombo1()
        {
            comboBox2.Items.Clear();
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Select Sec_Name From Section_Master", con.ActiveCon());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBox2.Items.Add(dr["Sec_Name"].ToString());
            }


        }
        private void fillcombo2()
        {
            comboBox3.Items.Clear();
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Select Rack_Name From Rack_Master", con.ActiveCon());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBox3.Items.Add(dr["Rack_Name"].ToString());
            }


        }
        void CreateNew()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox9.Clear();


            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Book", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox9.Text = dt.Rows[0][0].ToString();
            textBox1.Focus();
        }
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Book_Master]
           ([Book_Id]
           ,[Book_Name]
           ,[Book_Auth]
           ,[Book_Edition]
           ,[Book_Pages]
           ,[Book_Publish]
           ,[Sr_Id]
           ,[Book_Status]
           ,[Rack_Name]
           ,[Sec_Name])
     VALUES
           ('" + textBox9.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "','" + comboBox2.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void ViewGrid()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Book_Master", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Book_Id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Sr_Id"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Book_Name"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Book_Auth"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Book_Edition"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["Book_Pages"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["Book_Publish"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["Book_Status"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["Sec_Name"].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item["Rack_Name"].ToString();

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox9.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[8].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[n].Cells[10].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[n].Cells[9].Value.ToString();

        }
        void UpdateRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Book_Master]
            SET [Book_Name] = '" + textBox1.Text + "',[Book_Auth] = '" + textBox2.Text + "',[Book_Edition] = '" + textBox3.Text + "',[Book_Pages] = '" + textBox4.Text + "',[Book_Publish] = '" + textBox5.Text + "',[Sr_Id] = '" + textBox6.Text + "',[Book_Status] = '" + comboBox1.Text + "',[Rack_Name] = '" + comboBox3.Text + "',[Sec_Name] = '" + comboBox2.Text + "'WHERE [Book_Id] = '" + textBox9.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From [Book_Master]  WHERE [Book_Id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
