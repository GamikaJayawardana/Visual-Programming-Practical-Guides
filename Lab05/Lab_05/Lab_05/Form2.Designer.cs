namespace Lab_05
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDividend = new TextBox();
            txtDivisor = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(107, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Divide";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 32);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 1;
            label1.Text = "Divide Two Numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 83);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter the dividend";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 140);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 3;
            label3.Text = "Enter the divisor";
            // 
            // txtDividend
            // 
            txtDividend.Location = new Point(159, 80);
            txtDividend.Name = "txtDividend";
            txtDividend.Size = new Size(100, 23);
            txtDividend.TabIndex = 4;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(159, 137);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 259);
            Controls.Add(txtDivisor);
            Controls.Add(txtDividend);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDividend;
        private TextBox txtDivisor;
    }
}