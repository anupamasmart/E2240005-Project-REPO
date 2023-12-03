namespace E2240005_Project
{
    public partial class Login : Form
    {
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
            if (textBox1.Text == "admin" && textBox2.Text == "password")
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