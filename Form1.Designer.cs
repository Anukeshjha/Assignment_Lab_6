namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            EDIT = new DataGridViewButtonColumn();
            DELETE = new DataGridViewButtonColumn();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(433, 30);
            label1.Name = "label1";
            label1.Size = new Size(422, 38);
            label1.TabIndex = 0;
            label1.Text = "Student Registration";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 280);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(299, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 50);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "";
            textBox2.Location = new Point(299, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 50);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 50);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 218);
            label4.Name = "label4";
            label4.Size = new Size(63, 44);
            label4.TabIndex = 2;
            label4.Text = "Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 138);
            label3.Name = "label3";
            label3.Size = new Size(117, 44);
            label3.TabIndex = 1;
            label3.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(235, 44);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(420, 424);
            button2.Name = "button2";
            button2.Size = new Size(119, 61);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(128, 424);
            button3.Name = "button3";
            button3.Size = new Size(119, 61);
            button3.TabIndex = 4;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, EDIT, DELETE });
            dataGridView1.Location = new Point(669, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(768, 261);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "StudentName";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Course";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Fee";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // EDIT
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EDIT.DefaultCellStyle = dataGridViewCellStyle1;
            EDIT.HeaderText = "Edit";
            EDIT.MinimumWidth = 6;
            EDIT.Name = "EDIT";
            EDIT.Text = "Edit";
            EDIT.UseColumnTextForButtonValue = true;
            EDIT.Width = 125;
            // 
            // DELETE
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DELETE.DefaultCellStyle = dataGridViewCellStyle2;
            DELETE.HeaderText = "Delete";
            DELETE.MinimumWidth = 6;
            DELETE.Name = "DELETE";
            DELETE.Text = "Delete";
            DELETE.UseColumnTextForButtonValue = true;
            DELETE.Width = 125;
            // 
            // button4
            // 
            button4.AccessibleName = "";
            button4.Location = new Point(1029, 431);
            button4.Name = "button4";
            button4.Size = new Size(166, 47);
            button4.TabIndex = 7;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 506);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn EDIT;
        private DataGridViewButtonColumn DELETE;
        private Button button4;
    }
}