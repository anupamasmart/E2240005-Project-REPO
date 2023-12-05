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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            ViewGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteRecords();
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
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;

            comboBox2.SelectedIndex = -1;

            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Profile", con.ActiveCon());
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //textBox1.Text = dt.Rows[0][0].ToString();
            textBox1.Focus();
        }
        void AddRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Profile_Master]
           ([Pro_User_id]
           ,[Pro_Name]
           ,[Pro_Email]
           ,[Pro_Mobile]
           ,[Pro_Password]
           ,[Pro_Address]
           ,[Pro_Role]
           ,[Pro_Status])
     VALUES
           ( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void ViewGrid()
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Profile_Master", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Pro_User_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Pro_Name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Pro_Email"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Pro_Mobile"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Pro_Password"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["Pro_Address"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["Pro_Role"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["Pro_Status"].ToString();

            }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[n].Cells[8].Value.ToString();
        }
        void UpdateRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Profile_Master]
            SET [Pro_Name] = '" + textBox2.Text + "',[Pro_Email] = '" + textBox3.Text + "',[Pro_Mobile] = '" + textBox4.Text + "',[Pro_Password] = '" + textBox5.Text + "',[Pro_Address] = '" + textBox6.Text + "',[Pro_Role] = '" + comboBox1.Text + "',[Pro_Status] = '" + comboBox2.Text + "'WHERE [Pro_User_id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecords()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(@"Delete From [Profile_Master]  WHERE [Pro_User_id] = '" + textBox1.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }
    }
}
