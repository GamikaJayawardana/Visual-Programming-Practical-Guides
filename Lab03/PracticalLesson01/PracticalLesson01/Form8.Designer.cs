namespace PracticalLesson01
{
    partial class Form8
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
            richTextBox1 = new RichTextBox();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(239, 229);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(105, 260);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 302);
            Controls.Add(btnPrint);
            Controls.Add(richTextBox1);
            Name = "Form8";
            Text = "Exercise 08";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnPrint;
    }
}