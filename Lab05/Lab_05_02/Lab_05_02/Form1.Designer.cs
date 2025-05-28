namespace Lab_05_02
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
            txtIncome = new TextBox();
            txtTax = new TextBox();
            btnCal = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 25);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 0;
            label1.Text = "Tax Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Annual Income";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 114);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Income Tax";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(171, 73);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(170, 23);
            txtIncome.TabIndex = 3;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(171, 111);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(170, 23);
            txtTax.TabIndex = 4;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(31, 161);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(75, 23);
            btnCal.TabIndex = 5;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(149, 161);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(266, 161);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 217);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCal);
            Controls.Add(txtTax);
            Controls.Add(txtIncome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIncome;
        private TextBox txtTax;
        private Button btnCal;
        private Button btnClear;
        private Button btnExit;
    }
}
