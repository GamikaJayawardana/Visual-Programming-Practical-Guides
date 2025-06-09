namespace DatabaseTest
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIndexNo = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtCity = new TextBox();
            btnAdd = new Button();
            btnUpadate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Index No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 63);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 99);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 133);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // txtIndexNo
            // 
            txtIndexNo.Location = new Point(107, 27);
            txtIndexNo.Name = "txtIndexNo";
            txtIndexNo.Size = new Size(226, 23);
            txtIndexNo.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 23);
            txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(107, 96);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(226, 23);
            txtAge.TabIndex = 6;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(107, 130);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(226, 23);
            txtCity.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(107, 201);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpadate
            // 
            btnUpadate.Location = new Point(232, 201);
            btnUpadate.Name = "btnUpadate";
            btnUpadate.Size = new Size(75, 23);
            btnUpadate.TabIndex = 9;
            btnUpadate.Text = "Update";
            btnUpadate.UseVisualStyleBackColor = true;
            btnUpadate.Click += btnUpadate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(354, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(405, 76);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(532, 192);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpadate);
            Controls.Add(btnAdd);
            Controls.Add(txtCity);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtIndexNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student CRUD App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIndexNo;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtCity;
        private Button btnAdd;
        private Button btnUpadate;
        private Button btnDelete;
        private Button btnLoad;
        private DataGridView dataGridView1;
    }
}
