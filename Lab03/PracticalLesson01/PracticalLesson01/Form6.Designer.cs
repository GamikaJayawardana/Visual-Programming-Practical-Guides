namespace PracticalLesson01
{
    partial class Form6
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
            lstMaster = new CheckedListBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lstMaster
            // 
            lstMaster.CheckOnClick = true;
            lstMaster.FormattingEnabled = true;
            lstMaster.Location = new Point(34, 19);
            lstMaster.Name = "lstMaster";
            lstMaster.Size = new Size(220, 202);
            lstMaster.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(98, 240);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 275);
            Controls.Add(btnOk);
            Controls.Add(lstMaster);
            Name = "Form6";
            Text = "Exercise 06";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox lstMaster;
        private Button btnOk;
    }
}