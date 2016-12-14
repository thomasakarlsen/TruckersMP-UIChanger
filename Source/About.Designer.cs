namespace UIChanger
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.versionLabel = new System.Windows.Forms.Label();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.Footer_Panel = new System.Windows.Forms.Panel();
            this.githubLink = new System.Windows.Forms.Label();
            this.legalLink = new System.Windows.Forms.Label();
            this.devLink = new System.Windows.Forms.Label();
            this.Footer_seperator = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Header_Panel.SuspendLayout();
            this.Footer_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(304, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(262, 66);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version: 1.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.Header_Panel.Controls.Add(this.label1);
            this.Header_Panel.Controls.Add(this.versionLabel);
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(566, 66);
            this.Header_Panel.TabIndex = 65;
            // 
            // aboutLabel
            // 
            this.aboutLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(15, 81);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(539, 94);
            this.aboutLabel.TabIndex = 64;
            this.aboutLabel.Text = "Simple quick and easy application to change the UI skin of TruckersMP.\r\n\r\nTrucker" +
    "sMP UI Changer is not associated with the TruckersMP mod/team, SCS Software or T" +
    "ruckers.FM.";
            // 
            // Footer_Panel
            // 
            this.Footer_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_Panel.Controls.Add(this.panel1);
            this.Footer_Panel.Controls.Add(this.githubLink);
            this.Footer_Panel.Controls.Add(this.legalLink);
            this.Footer_Panel.Controls.Add(this.devLink);
            this.Footer_Panel.Controls.Add(this.Footer_seperator);
            this.Footer_Panel.Location = new System.Drawing.Point(0, 312);
            this.Footer_Panel.Name = "Footer_Panel";
            this.Footer_Panel.Size = new System.Drawing.Size(566, 37);
            this.Footer_Panel.TabIndex = 66;
            // 
            // githubLink
            // 
            this.githubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubLink.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.githubLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.githubLink.Location = new System.Drawing.Point(342, 1);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(124, 36);
            this.githubLink.TabIndex = 54;
            this.githubLink.Text = "GitHub Repository";
            this.githubLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.githubLink.Click += new System.EventHandler(this.githubLink_Click);
            // 
            // legalLink
            // 
            this.legalLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.legalLink.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.legalLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.legalLink.Location = new System.Drawing.Point(181, 1);
            this.legalLink.Name = "legalLink";
            this.legalLink.Size = new System.Drawing.Size(155, 36);
            this.legalLink.TabIndex = 53;
            this.legalLink.Text = "License and Disclaimers";
            this.legalLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.legalLink.Click += new System.EventHandler(this.legalLink_Click);
            // 
            // devLink
            // 
            this.devLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devLink.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.devLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.devLink.Location = new System.Drawing.Point(3, 1);
            this.devLink.Name = "devLink";
            this.devLink.Size = new System.Drawing.Size(172, 36);
            this.devLink.TabIndex = 51;
            this.devLink.Text = "Coded By TheUnknownNO";
            this.devLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.devLink.Click += new System.EventHandler(this.devLink_Click);
            // 
            // Footer_seperator
            // 
            this.Footer_seperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_seperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Footer_seperator.Location = new System.Drawing.Point(-6, -12);
            this.Footer_seperator.Name = "Footer_seperator";
            this.Footer_seperator.Size = new System.Drawing.Size(566, 1);
            this.Footer_seperator.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 1);
            this.panel1.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "TruckersMP UI Changer";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 348);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.Footer_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "TruckersMP UI Changer | About";
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            this.Footer_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Panel Footer_Panel;
        private System.Windows.Forms.Label githubLink;
        private System.Windows.Forms.Label legalLink;
        private System.Windows.Forms.Label devLink;
        private System.Windows.Forms.Panel Footer_seperator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}