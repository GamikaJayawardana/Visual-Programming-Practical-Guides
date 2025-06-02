namespace Lab_06_01_02
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
            txtName = new TextBox();
            txtMarks = new TextBox();
            txtResult = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 26);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 0;
            label1.Text = "Student Result Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 88);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 130);
            label3.Name = "label3";
            label3.Size = new Size(184, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter 5 Marks (comma separated)";
            // 
            // txtName
            // 
            txtName.Location = new Point(235, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtMarks
            // 
            txtMarks.Location = new Point(235, 127);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(100, 23);
            txtMarks.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(78, 174);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(212, 70);
            txtResult.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(78, 269);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(215, 269);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 331);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(txtMarks);
            Controls.Add(txtName);
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
        private TextBox txtName;
        private TextBox txtMarks;
        private TextBox txtResult;
        private Button btnCalculate;
        private Button btnClear;
    }
}
