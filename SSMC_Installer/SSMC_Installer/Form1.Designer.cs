namespace SSMC_Installer
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
            txtDestination = new TextBox();
            label1 = new Label();
            btnBrowse = new Button();
            btnInstall = new Button();
            SuspendLayout();
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(12, 38);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(239, 27);
            txtDestination.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Install Destination";
            label1.Click += label1_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(257, 38);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnInstall
            // 
            btnInstall.Location = new Point(125, 74);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(94, 29);
            btnInstall.TabIndex = 3;
            btnInstall.Text = "Install";
            btnInstall.UseVisualStyleBackColor = true;
            btnInstall.Click += btnInstall_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 115);
            Controls.Add(btnInstall);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(txtDestination);
            Name = "Form1";
            Text = "SMSC Installer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDestination;
        private Label label1;
        private Button btnBrowse;
        private Button btnInstall;
    }
}
