namespace PanoramaVideo
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnBVid = new System.Windows.Forms.Button();
            this.tbxVid = new System.Windows.Forms.TextBox();
            this.lblVid = new System.Windows.Forms.Label();
            this.btnBDir = new System.Windows.Forms.Button();
            this.tbxDir = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConf);
            this.panel1.Controls.Add(this.btnBVid);
            this.panel1.Controls.Add(this.tbxVid);
            this.panel1.Controls.Add(this.lblVid);
            this.panel1.Controls.Add(this.btnBDir);
            this.panel1.Controls.Add(this.tbxDir);
            this.panel1.Controls.Add(this.lblDir);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(191, 59);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 23);
            this.btnConf.TabIndex = 6;
            this.btnConf.Text = "Confirm";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnBVid
            // 
            this.btnBVid.Location = new System.Drawing.Point(357, 31);
            this.btnBVid.Name = "btnBVid";
            this.btnBVid.Size = new System.Drawing.Size(75, 23);
            this.btnBVid.TabIndex = 5;
            this.btnBVid.Text = "Browse...";
            this.btnBVid.UseVisualStyleBackColor = true;
            this.btnBVid.Click += new System.EventHandler(this.btnBVid_Click);
            // 
            // tbxVid
            // 
            this.tbxVid.Location = new System.Drawing.Point(118, 33);
            this.tbxVid.Name = "tbxVid";
            this.tbxVid.Size = new System.Drawing.Size(233, 20);
            this.tbxVid.TabIndex = 4;
            this.tbxVid.Text = "C:\\Users\\Default\\Videos";
            // 
            // lblVid
            // 
            this.lblVid.AutoSize = true;
            this.lblVid.Location = new System.Drawing.Point(3, 36);
            this.lblVid.Name = "lblVid";
            this.lblVid.Size = new System.Drawing.Size(69, 13);
            this.lblVid.TabIndex = 3;
            this.lblVid.Text = "Select video:";
            // 
            // btnBDir
            // 
            this.btnBDir.Location = new System.Drawing.Point(357, 4);
            this.btnBDir.Name = "btnBDir";
            this.btnBDir.Size = new System.Drawing.Size(75, 23);
            this.btnBDir.TabIndex = 2;
            this.btnBDir.Text = "Browse...";
            this.btnBDir.UseVisualStyleBackColor = true;
            this.btnBDir.Click += new System.EventHandler(this.btnBDir_Click);
            // 
            // tbxDir
            // 
            this.tbxDir.Location = new System.Drawing.Point(118, 6);
            this.tbxDir.Name = "tbxDir";
            this.tbxDir.Size = new System.Drawing.Size(233, 20);
            this.tbxDir.TabIndex = 1;
            this.tbxDir.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(3, 9);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(109, 13);
            this.lblDir.TabIndex = 0;
            this.lblDir.Text = "Select csgo directory:";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Video Files (*.webm;*.mp4)|*.webm;*.mp4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 126);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panorama Video Replace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnBVid;
        private System.Windows.Forms.TextBox tbxVid;
        private System.Windows.Forms.Label lblVid;
        private System.Windows.Forms.Button btnBDir;
        private System.Windows.Forms.TextBox tbxDir;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label1;
    }
}

