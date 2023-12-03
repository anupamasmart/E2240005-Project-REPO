using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2240005_Project
{
    public partial class LMS : Form
    {

        public LMS()
        {
            InitializeComponent();
        }

        private void LMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role obj = new Role();
            obj.MdiParent = this;
            obj.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.MdiParent = this;
            obj.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member obj = new Member();
            obj.MdiParent = this;
            obj.Show();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan obj = new Plan();
            obj.MdiParent = this;
            obj.Show();
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rack obj = new Rack();
            obj.MdiParent = this;
            obj.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section obj = new Section();
            obj.MdiParent = this;
            obj.Show();
        }

        private void sectionRackMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section_Rack_Map obj = new Section_Rack_Map();
            obj.MdiParent = this;
            obj.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password obj = new Change_Password();
            obj.MdiParent = this;
            obj.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase obj = new Purchase();
            obj.MdiParent = this;
            obj.Show();
        }

        private void bookInRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_In_register obj = new Book_In_register();
            obj.MdiParent = this;
            obj.Show();
        }

        private void bookOutRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Out_Register obj = new Book_Out_Register();
            obj.MdiParent = this;
            obj.Show();
        }

        private void memberTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Transaction obj = new Member_Transaction();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
