namespace PracticalLesson01
{
    partial class Form5
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
            progressBar1 = new ProgressBar();
            btnOk = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(36, 34);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(390, 23);
            progressBar1.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(187, 76);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 129);
            Controls.Add(btnOk);
            Controls.Add(progressBar1);
            Name = "Form5";
            Text = "Exercise 05";
            Load += Form5_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btnOk;
    }
}