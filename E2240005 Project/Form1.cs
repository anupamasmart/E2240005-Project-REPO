using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace E2240005_Project
{
    public partial class Login : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BITlmsDB;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Profile_Master Where Pro_User_id= '" + textBox1.Text + "'and Pro_Password = '" + textBox2.Text + "' ", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                LMS obj = new LMS();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password..!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}