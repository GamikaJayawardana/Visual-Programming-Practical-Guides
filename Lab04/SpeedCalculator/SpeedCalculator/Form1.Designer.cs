namespace SpeedCalculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTime = new TextBox();
            txtDistance = new TextBox();
            btnCal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 34);
            label1.Name = "label1";
            label1.Size = new Size(248, 40);
            label1.TabIndex = 0;
            label1.Text = "Speed Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 102);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Time in Minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 153);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Distance in Kilometers";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(272, 99);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 3;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(272, 150);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(100, 23);
            txtDistance.TabIndex = 4;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(172, 207);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(75, 23);
            btnCal.TabIndex = 5;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 287);
            Controls.Add(btnCal);
            Controls.Add(txtDistance);
            Controls.Add(txtTime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTime;
        private TextBox txtDistance;
        private Button btnCal;
    }
}
