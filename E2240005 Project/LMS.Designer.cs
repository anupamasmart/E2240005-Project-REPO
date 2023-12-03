﻿namespace E2240005_Project
{
    partial class LMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            roleToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            planToolStripMenuItem = new ToolStripMenuItem();
            rackToolStripMenuItem = new ToolStripMenuItem();
            sectionToolStripMenuItem = new ToolStripMenuItem();
            sectionRackMapToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            bookInRegisterToolStripMenuItem = new ToolStripMenuItem();
            bookOutRegisterToolStripMenuItem = new ToolStripMenuItem();
            memberTransactionToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, inventoryToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(843, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { roleToolStripMenuItem, profileToolStripMenuItem, memberToolStripMenuItem, planToolStripMenuItem, rackToolStripMenuItem, sectionToolStripMenuItem, sectionRackMapToolStripMenuItem, changePasswordToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(68, 24);
            toolStripMenuItem1.Text = "Master";
            // 
            // roleToolStripMenuItem
            // 
            roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            roleToolStripMenuItem.Size = new Size(210, 26);
            roleToolStripMenuItem.Text = "Role";
            roleToolStripMenuItem.Click += roleToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(210, 26);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(210, 26);
            memberToolStripMenuItem.Text = "Member";
            memberToolStripMenuItem.Click += memberToolStripMenuItem_Click;
            // 
            // planToolStripMenuItem
            // 
            planToolStripMenuItem.Name = "planToolStripMenuItem";
            planToolStripMenuItem.Size = new Size(210, 26);
            planToolStripMenuItem.Text = "Plan";
            planToolStripMenuItem.Click += planToolStripMenuItem_Click;
            // 
            // rackToolStripMenuItem
            // 
            rackToolStripMenuItem.Name = "rackToolStripMenuItem";
            rackToolStripMenuItem.Size = new Size(210, 26);
            rackToolStripMenuItem.Text = "Rack";
            rackToolStripMenuItem.Click += rackToolStripMenuItem_Click;
            // 
            // sectionToolStripMenuItem
            // 
            sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            sectionToolStripMenuItem.Size = new Size(210, 26);
            sectionToolStripMenuItem.Text = "Section";
            sectionToolStripMenuItem.Click += sectionToolStripMenuItem_Click;
            // 
            // sectionRackMapToolStripMenuItem
            // 
            sectionRackMapToolStripMenuItem.Name = "sectionRackMapToolStripMenuItem";
            sectionRackMapToolStripMenuItem.Size = new Size(210, 26);
            sectionRackMapToolStripMenuItem.Text = "Section Rack Map";
            sectionRackMapToolStripMenuItem.Click += sectionRackMapToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(210, 26);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { purchaseToolStripMenuItem, bookInRegisterToolStripMenuItem, bookOutRegisterToolStripMenuItem, memberTransactionToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(75, 24);
            inventoryToolStripMenuItem.Text = "Inventry";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(227, 26);
            purchaseToolStripMenuItem.Text = "Purchase";
            purchaseToolStripMenuItem.Click += purchaseToolStripMenuItem_Click;
            // 
            // bookInRegisterToolStripMenuItem
            // 
            bookInRegisterToolStripMenuItem.Name = "bookInRegisterToolStripMenuItem";
            bookInRegisterToolStripMenuItem.Size = new Size(227, 26);
            bookInRegisterToolStripMenuItem.Text = "Book In Register";
            bookInRegisterToolStripMenuItem.Click += bookInRegisterToolStripMenuItem_Click;
            // 
            // bookOutRegisterToolStripMenuItem
            // 
            bookOutRegisterToolStripMenuItem.Name = "bookOutRegisterToolStripMenuItem";
            bookOutRegisterToolStripMenuItem.Size = new Size(227, 26);
            bookOutRegisterToolStripMenuItem.Text = "Book Out Register";
            bookOutRegisterToolStripMenuItem.Click += bookOutRegisterToolStripMenuItem_Click;
            // 
            // memberTransactionToolStripMenuItem
            // 
            memberTransactionToolStripMenuItem.Name = "memberTransactionToolStripMenuItem";
            memberTransactionToolStripMenuItem.Size = new Size(227, 26);
            memberTransactionToolStripMenuItem.Text = "Member Transaction";
            memberTransactionToolStripMenuItem.Click += memberTransactionToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 671);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(843, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // LMS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 697);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LMS";
            Text = "LMS";
            FormClosed += LMS_FormClosed;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem roleToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem planToolStripMenuItem;
        private ToolStripMenuItem rackToolStripMenuItem;
        private ToolStripMenuItem sectionToolStripMenuItem;
        private ToolStripMenuItem sectionRackMapToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem bookInRegisterToolStripMenuItem;
        private ToolStripMenuItem bookOutRegisterToolStripMenuItem;
        private ToolStripMenuItem memberTransactionToolStripMenuItem;
    }
}



