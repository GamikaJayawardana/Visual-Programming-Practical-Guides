namespace PracticalLesson01
{
    partial class Form4
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
            btnFont = new Button();
            btnColor = new Button();
            lblShow = new Label();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // btnFont
            // 
            btnFont.Location = new Point(24, 21);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(99, 23);
            btnFont.TabIndex = 0;
            btnFont.Text = "Change Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(141, 21);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(102, 23);
            btnColor.TabIndex = 1;
            btnColor.Text = "Change Colour";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShow.Location = new Point(46, 62);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(184, 25);
            lblShow.TabIndex = 2;
            lblShow.Text = "Visual Programming";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 129);
            Controls.Add(lblShow);
            Controls.Add(btnColor);
            Controls.Add(btnFont);
            Name = "Form4";
            Text = "Execise 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFont;
        private Button btnColor;
        private Label lblShow;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}