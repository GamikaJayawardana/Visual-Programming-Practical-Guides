namespace Lab_05
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
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(157, 78);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(100, 23);
            txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(157, 135);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(100, 23);
            txtnum2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 81);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 138);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 32);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 4;
            label3.Text = "Add Two Numbers";
            // 
            // button1
            // 
            button1.Location = new Point(112, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 250);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum1;
        private TextBox txtnum2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
