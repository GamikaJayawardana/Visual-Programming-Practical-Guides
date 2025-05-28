namespace Lab_05_02
{
    partial class Form2
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtCountry = new TextBox();
            Female = new RadioButton();
            Male = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Akira Expanded", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 42);
            label1.TabIndex = 0;
            label1.Text = "UNSW \r\nSYDNEY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(272, 25);
            label2.TabIndex = 1;
            label2.Text = "New Student Registration Form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Burton's Nightmare", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 24);
            label3.Name = "label3";
            label3.Size = new Size(258, 34);
            label3.TabIndex = 2;
            label3.Text = "Australia's Global University";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 137);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 169);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 207);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 258);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Country";
            label7.Click += label7_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 23);
            txtName.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(126, 166);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(204, 23);
            txtAge.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(126, 255);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(204, 23);
            txtCountry.TabIndex = 9;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(126, 205);
            Female.Name = "Female";
            Female.Size = new Size(63, 19);
            Female.TabIndex = 10;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(126, 227);
            Male.Name = "Male";
            Male.Size = new Size(51, 19);
            Male.TabIndex = 11;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            Male.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(185, 300);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 346);
            Controls.Add(button1);
            Controls.Add(Male);
            Controls.Add(Female);
            Controls.Add(txtCountry);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtCountry;
        private RadioButton Female;
        private RadioButton Male;
        private Button button1;
    }
}