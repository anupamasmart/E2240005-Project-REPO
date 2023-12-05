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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace E2240005_Project
{
    public partial class Member : Form
    {
        public Member()
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
        void CreateNew()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Update();
            dateTimePicker2.Update();

            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Member", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //textBox1.Text = dt.Rows[0][0].ToString();
            textBox1.Focus();
        }
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Member_Master]
           ([Mem_id]
           ,[Mem_Name]
           ,[Mem_Email]
           ,[Mem_Mobile]
           ,[Mem_Address]
           ,[Mem_Dob]
           ,[Mem_Doj]
           ,[Plan_id]
           ,[Mem_Status])
     VALUES
           ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox8.Text + "','" + comboBox2.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void ViewGrid()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Member_Master", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Mem_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Mem_Name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Mem_Email"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Mem_Mobile"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Mem_Address"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["Mem_Dob"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["Mem_Doj"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["Plan_id"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["Mem_Status"].ToString();


            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.Rows[n].Cells[8].Value.ToString();
            //comboBox1.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[n].Cells[9].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
        }
        void UpdateRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Member_Master]
            SET [Mem_Name] = '" + textBox2.Text + "',[Mem_Email] = '" + textBox3.Text + "',[Mem_Mobile] = '" + textBox4.Text + "',[Mem_Address] = '" + textBox7.Text + "',[Mem_Dob] = '" + dateTimePicker1.Text + "',[Mem_Doj] = '" + dateTimePicker2 + "',[Plan_id] = '" + textBox8.Text + "',,[Mem_Status] = '" + comboBox2.Text + "'WHERE [Mem_id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From [Member_Master]  WHERE [Mem_id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }
    }
}
