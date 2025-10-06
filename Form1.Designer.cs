namespace _04TaskPerformance1_100625
{
    partial class frmTrackThread
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
            lblThread = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Segoe UI", 15F);
            lblThread.Location = new Point(110, 84);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(142, 28);
            lblThread.TabIndex = 0;
            lblThread.Text = "-Thread Starts-";
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 15F);
            btnRun.Location = new Point(127, 168);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(125, 38);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 233);
            Controls.Add(btnRun);
            Controls.Add(lblThread);
            Name = "frmTrackThread";
            Text = "frmTrackTread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThread;
        private Button btnRun;
    }
}
