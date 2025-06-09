namespace DatabaseTest
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
            txtIndexNo = new TextBox();
            txtName = new TextBox();
            btnFirst = new Button();
            btnLast = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Docter Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Doctor Name";
            label2.Click += label2_Click;
            // 
            // txtIndexNo
            // 
            txtIndexNo.Location = new Point(187, 38);
            txtIndexNo.Name = "txtIndexNo";
            txtIndexNo.Size = new Size(256, 23);
            txtIndexNo.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(187, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 23);
            txtName.TabIndex = 3;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(115, 131);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(62, 23);
            btnFirst.TabIndex = 4;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(187, 131);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(61, 23);
            btnLast.TabIndex = 5;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(115, 170);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(62, 23);
            btnPrev.TabIndex = 6;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(187, 170);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(61, 23);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(40, 170);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(55, 23);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 221);
            Controls.Add(btnLoad);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnLast);
            Controls.Add(btnFirst);
            Controls.Add(txtName);
            Controls.Add(txtIndexNo);
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
        private TextBox txtIndexNo;
        private TextBox txtName;
        private Button btnFirst;
        private Button btnLast;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLoad;
    }
}