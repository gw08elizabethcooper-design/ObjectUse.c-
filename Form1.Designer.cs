namespace Assesment1c_
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
            lbl = new Label();
            FileSizetxt = new TextBox();
            Submitbtn = new Button();
            FileSizeslbl = new Label();
            LargestFilelbl = new Label();
            FileCountlbl = new Label();
            TotalMemorylbl = new Label();
            Averagelbl = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(258, 30);
            lbl.Name = "lbl";
            lbl.Size = new Size(270, 28);
            lbl.TabIndex = 0;
            lbl.Text = "Enter File Sizes, One at a time.";
            // 
            // FileSizetxt
            // 
            FileSizetxt.Location = new Point(311, 83);
            FileSizetxt.Name = "FileSizetxt";
            FileSizetxt.Size = new Size(125, 27);
            FileSizetxt.TabIndex = 1;
            FileSizetxt.Text = "Enter...";
            // 
            // Submitbtn
            // 
            Submitbtn.Location = new Point(340, 128);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(75, 29);
            Submitbtn.TabIndex = 2;
            Submitbtn.Text = "Submit";
            Submitbtn.UseVisualStyleBackColor = true;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // FileSizeslbl
            // 
            FileSizeslbl.AutoSize = true;
            FileSizeslbl.Location = new Point(162, 181);
            FileSizeslbl.Name = "FileSizeslbl";
            FileSizeslbl.Size = new Size(0, 20);
            FileSizeslbl.TabIndex = 3;
            // 
            // LargestFilelbl
            // 
            LargestFilelbl.AutoSize = true;
            LargestFilelbl.Location = new Point(46, 239);
            LargestFilelbl.Name = "LargestFilelbl";
            LargestFilelbl.Size = new Size(84, 20);
            LargestFilelbl.TabIndex = 4;
            LargestFilelbl.Text = "Largest File";
            // 
            // FileCountlbl
            // 
            FileCountlbl.AutoSize = true;
            FileCountlbl.Location = new Point(162, 323);
            FileCountlbl.Name = "FileCountlbl";
            FileCountlbl.Size = new Size(75, 20);
            FileCountlbl.TabIndex = 5;
            FileCountlbl.Text = "File Count";
            // 
            // TotalMemorylbl
            // 
            TotalMemorylbl.AutoSize = true;
            TotalMemorylbl.Location = new Point(311, 419);
            TotalMemorylbl.Name = "TotalMemorylbl";
            TotalMemorylbl.Size = new Size(68, 20);
            TotalMemorylbl.TabIndex = 6;
            TotalMemorylbl.Text = "Total MB";
            // 
            // Averagelbl
            // 
            Averagelbl.AutoSize = true;
            Averagelbl.Location = new Point(464, 529);
            Averagelbl.Name = "Averagelbl";
            Averagelbl.Size = new Size(64, 20);
            Averagelbl.TabIndex = 7;
            Averagelbl.Text = "Average";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 803);
            Controls.Add(Averagelbl);
            Controls.Add(TotalMemorylbl);
            Controls.Add(FileCountlbl);
            Controls.Add(LargestFilelbl);
            Controls.Add(FileSizeslbl);
            Controls.Add(Submitbtn);
            Controls.Add(FileSizetxt);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox FileSizetxt;
        private Button Submitbtn;
        private Label FileSizeslbl;
        private Label LargestFilelbl;
        private Label FileCountlbl;
        private Label TotalMemorylbl;
        private Label Averagelbl;
    }
}
