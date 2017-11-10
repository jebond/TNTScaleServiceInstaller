namespace TNTScaleServiceInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.pathlabel = new System.Windows.Forms.Label();
            this.pathlog = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.debuglabel = new System.Windows.Forms.Label();
            this.txtdebug = new System.Windows.Forms.TextBox();
            this.btnsaveconfig = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btninstall = new System.Windows.Forms.Button();
            this.txtsec = new System.Windows.Forms.TextBox();
            this.lblsec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Output Directory";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(285, 59);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(183, 20);
            this.txtpath.TabIndex = 2;
            this.txtpath.Text = "http://serverip";
            this.txtpath.Visible = false;
            // 
            // pathlabel
            // 
            this.pathlabel.AutoSize = true;
            this.pathlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathlabel.Location = new System.Drawing.Point(124, 57);
            this.pathlabel.Name = "pathlabel";
            this.pathlabel.Size = new System.Drawing.Size(154, 20);
            this.pathlabel.TabIndex = 3;
            this.pathlabel.Text = "Path to Scale Server";
            this.pathlabel.Visible = false;
            // 
            // pathlog
            // 
            this.pathlog.AutoSize = true;
            this.pathlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathlog.Location = new System.Drawing.Point(124, 98);
            this.pathlog.Name = "pathlog";
            this.pathlog.Size = new System.Drawing.Size(133, 20);
            this.pathlog.TabIndex = 4;
            this.pathlog.Text = "Path for Log Files";
            this.pathlog.Visible = false;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(285, 98);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(183, 20);
            this.txtlog.TabIndex = 5;
            this.txtlog.Text = "C:/Pathforlogfile";
            this.txtlog.Visible = false;
            // 
            // debuglabel
            // 
            this.debuglabel.AutoSize = true;
            this.debuglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debuglabel.Location = new System.Drawing.Point(124, 141);
            this.debuglabel.Name = "debuglabel";
            this.debuglabel.Size = new System.Drawing.Size(57, 20);
            this.debuglabel.TabIndex = 6;
            this.debuglabel.Text = "Debug";
            this.debuglabel.Visible = false;
            // 
            // txtdebug
            // 
            this.txtdebug.Location = new System.Drawing.Point(285, 141);
            this.txtdebug.Name = "txtdebug";
            this.txtdebug.Size = new System.Drawing.Size(183, 20);
            this.txtdebug.TabIndex = 7;
            this.txtdebug.Text = "True or False";
            this.txtdebug.Visible = false;
            // 
            // btnsaveconfig
            // 
            this.btnsaveconfig.Location = new System.Drawing.Point(393, 214);
            this.btnsaveconfig.Name = "btnsaveconfig";
            this.btnsaveconfig.Size = new System.Drawing.Size(75, 23);
            this.btnsaveconfig.TabIndex = 8;
            this.btnsaveconfig.Text = "Save Config";
            this.btnsaveconfig.UseVisualStyleBackColor = true;
            this.btnsaveconfig.Visible = false;
            this.btnsaveconfig.Click += new System.EventHandler(this.btnsaveconfig_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.ForeColor = System.Drawing.Color.Red;
            this.lblstatus.Location = new System.Drawing.Point(35, 271);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(66, 13);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Status Label";
            this.lblstatus.Visible = false;
            // 
            // btninstall
            // 
            this.btninstall.Location = new System.Drawing.Point(352, 244);
            this.btninstall.Name = "btninstall";
            this.btninstall.Size = new System.Drawing.Size(116, 23);
            this.btninstall.TabIndex = 11;
            this.btninstall.Text = "Run Service Install";
            this.btninstall.UseVisualStyleBackColor = true;
            this.btninstall.Visible = false;
            this.btninstall.Click += new System.EventHandler(this.btninstall_Click);
            // 
            // txtsec
            // 
            this.txtsec.Location = new System.Drawing.Point(285, 177);
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(183, 20);
            this.txtsec.TabIndex = 13;
            this.txtsec.Text = "500";
            this.txtsec.Visible = false;
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.Location = new System.Drawing.Point(124, 177);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(99, 20);
            this.lblsec.TabIndex = 12;
            this.lblsec.Text = "Scale Timing";
            this.lblsec.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 299);
            this.Controls.Add(this.txtsec);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.btninstall);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsaveconfig);
            this.Controls.Add(this.txtdebug);
            this.Controls.Add(this.debuglabel);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.pathlog);
            this.Controls.Add(this.pathlabel);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TNT Scale Service Installer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label pathlabel;
        private System.Windows.Forms.Label pathlog;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Label debuglabel;
        private System.Windows.Forms.TextBox txtdebug;
        private System.Windows.Forms.Button btnsaveconfig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btninstall;
        private System.Windows.Forms.TextBox txtsec;
        private System.Windows.Forms.Label lblsec;
    }
}

