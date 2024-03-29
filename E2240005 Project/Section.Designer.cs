﻿namespace E2240005_Project
{
    partial class Section
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
            btnNew = new Button();
            btnUpdata = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            SectionID = new DataGridViewTextBoxColumn();
            SectionName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 59);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "SectionID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 109);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Section Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 162);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(563, 52);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(137, 57);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdata
            // 
            btnUpdata.Location = new Point(563, 135);
            btnUpdata.Name = "btnUpdata";
            btnUpdata.Size = new Size(137, 59);
            btnUpdata.TabIndex = 4;
            btnUpdata.Text = "Updata";
            btnUpdata.UseVisualStyleBackColor = true;
            btnUpdata.Click += btnUpdata_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(717, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 57);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(717, 135);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 59);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 27);
            textBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Open to Public", "Close to Public", "Privet", "Top Priority", "Other" });
            comboBox1.Location = new Point(228, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 28);
            comboBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, SectionID, SectionName, Status });
            dataGridView1.Location = new Point(82, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1086, 205);
            dataGridView1.TabIndex = 10;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // SectionID
            // 
            SectionID.HeaderText = "SectionID";
            SectionID.MinimumWidth = 6;
            SectionID.Name = "SectionID";
            // 
            // SectionName
            // 
            SectionName.HeaderText = "Section Name";
            SectionName.MinimumWidth = 6;
            SectionName.Name = "SectionName";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Section
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(1289, 621);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdata);
            Controls.Add(btnNew);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Section";
            Text = "Section";
            WindowState = FormWindowState.Maximized;
            Load += Section_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnNew;
        private Button btnUpdata;
        private Button btnDelete;
        private Button btnSave;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn SectionID;
        private DataGridViewTextBoxColumn SectionName;
        private DataGridViewTextBoxColumn Status;
    }
}