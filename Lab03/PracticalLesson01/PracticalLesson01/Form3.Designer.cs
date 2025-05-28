namespace PracticalLesson01
{
    partial class Form3
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
            cmbCity = new ComboBox();
            btnEvaluate = new Button();
            lblDisplay = new Label();
            SuspendLayout();
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Items.AddRange(new object[] { "Ratnapura", "Colombo", "Gampaha", "Kegalle", "Galle" });
            cmbCity.Location = new Point(36, 24);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(121, 23);
            cmbCity.TabIndex = 0;
            // 
            // btnEvaluate
            // 
            btnEvaluate.Location = new Point(59, 70);
            btnEvaluate.Name = "btnEvaluate";
            btnEvaluate.Size = new Size(75, 23);
            btnEvaluate.TabIndex = 1;
            btnEvaluate.Text = "Ok";
            btnEvaluate.UseVisualStyleBackColor = true;
            btnEvaluate.Click += btnEvaluate_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(22, 113);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 15);
            lblDisplay.TabIndex = 2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 156);
            Controls.Add(lblDisplay);
            Controls.Add(btnEvaluate);
            Controls.Add(cmbCity);
            Name = "Form3";
            Text = "Exercise 03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCity;
        private Button btnEvaluate;
        private Label lblDisplay;
    }
}