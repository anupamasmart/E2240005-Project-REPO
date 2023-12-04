namespace E2240005_Project
{
    partial class Role
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            RoleID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 27);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Role ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 151);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(256, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 27);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBox1.Location = new Point(244, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 28);
            comboBox1.TabIndex = 5;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(576, 28);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(136, 45);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(576, 82);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 47);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(735, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 47);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(735, 82);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 47);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RoleID, dataGridViewTextBoxColumn1, Status });
            dataGridView1.Location = new Point(65, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(868, 206);
            dataGridView1.TabIndex = 10;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // RoleID
            // 
            RoleID.HeaderText = "RoleID";
            RoleID.MinimumWidth = 6;
            RoleID.Name = "RoleID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Role";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Role
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 490);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Role";
            Text = "Role";
            Load += Role_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RoleID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Status;
    }
}