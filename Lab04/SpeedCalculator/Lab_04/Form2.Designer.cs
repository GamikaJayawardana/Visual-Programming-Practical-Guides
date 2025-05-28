namespace Lab_04
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
            label1 = new Label();
            label2 = new Label();
            txtTime = new TextBox();
            label3 = new Label();
            txtDistance = new TextBox();
            btnCal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 23);
            label1.Name = "label1";
            label1.Size = new Size(248, 40);
            label1.TabIndex = 0;
            label1.Text = "Speed Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 93);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Time in Minutes";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(256, 90);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 145);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 3;
            label3.Text = "Enter Distance in Kilometers";
            label3.Click += label3_Click;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(256, 142);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(100, 23);
            txtDistance.TabIndex = 4;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(167, 204);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(75, 23);
            btnCal.TabIndex = 5;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 266);
            Controls.Add(btnCal);
            Controls.Add(txtDistance);
            Controls.Add(label3);
            Controls.Add(txtTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTime;
        private Label label3;
        private TextBox txtDistance;
        private Button btnCal;
    }
}