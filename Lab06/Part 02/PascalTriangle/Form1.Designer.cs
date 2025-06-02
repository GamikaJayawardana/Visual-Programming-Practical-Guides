namespace PascalTriangle
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
            txtNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            btnOk = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(290, 64);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(34, 23);
            txtNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 26);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 1;
            label1.Text = "Pascal Triangle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(258, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter the height of the Pascal Triangle you need";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 104);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(298, 250);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(343, 240);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(343, 280);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 366);
            Controls.Add(btnExit);
            Controls.Add(btnOk);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button btnOk;
        private Button btnExit;
    }
}
