namespace PracticalLesson01
{
    partial class Form7
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
            components = new System.ComponentModel.Container();
            treeView1 = new TreeView();
            btnDisplay = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(22, 21);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(304, 399);
            treeView1.TabIndex = 0;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(122, 442);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 1;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 487);
            Controls.Add(btnDisplay);
            Controls.Add(treeView1);
            Name = "Form7";
            Text = "Exercise 07";
            Load += Form7_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Button btnDisplay;
        private ImageList imageList1;
    }
}