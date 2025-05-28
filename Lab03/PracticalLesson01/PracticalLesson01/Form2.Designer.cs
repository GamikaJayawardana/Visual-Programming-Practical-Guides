namespace PracticalLesson01
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
            txtInput = new TextBox();
            btnEvaluate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(29, 32);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(230, 23);
            txtInput.TabIndex = 0;
            // 
            // btnEvaluate
            // 
            btnEvaluate.Location = new Point(64, 83);
            btnEvaluate.Name = "btnEvaluate";
            btnEvaluate.Size = new Size(151, 23);
            btnEvaluate.TabIndex = 1;
            btnEvaluate.Text = "Evaluate My Choice";
            btnEvaluate.UseVisualStyleBackColor = true;
            btnEvaluate.Click += btnEvaluate_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 161);
            Controls.Add(btnEvaluate);
            Controls.Add(txtInput);
            Name = "Form2";
            Text = "Exercise 02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnEvaluate;
    }
}