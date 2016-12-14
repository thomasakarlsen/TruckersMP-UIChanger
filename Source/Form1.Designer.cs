namespace UIChanger
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
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Footer_Panel = new System.Windows.Forms.Panel();
            this.Footer_seperator = new System.Windows.Forms.Panel();
            this.about_tool = new System.Windows.Forms.Label();
            this.link_ets2mp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ets_browse = new System.Windows.Forms.Button();
            this.ats_browse = new System.Windows.Forms.Button();
            this.ats_file = new System.Windows.Forms.TextBox();
            this.ets_file = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Header_Panel.SuspendLayout();
            this.Footer_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_Panel
            // 
            this.Header_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.Header_Panel.Controls.Add(this.label1);
            this.Header_Panel.Location = new System.Drawing.Point(1, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(638, 66);
            this.Header_Panel.TabIndex = 62;
            // 
            // Footer_Panel
            // 
            this.Footer_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_Panel.Controls.Add(this.Footer_seperator);
            this.Footer_Panel.Controls.Add(this.about_tool);
            this.Footer_Panel.Controls.Add(this.link_ets2mp);
            this.Footer_Panel.Location = new System.Drawing.Point(0, 279);
            this.Footer_Panel.Name = "Footer_Panel";
            this.Footer_Panel.Size = new System.Drawing.Size(639, 37);
            this.Footer_Panel.TabIndex = 63;
            // 
            // Footer_seperator
            // 
            this.Footer_seperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_seperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Footer_seperator.Location = new System.Drawing.Point(0, 0);
            this.Footer_seperator.Name = "Footer_seperator";
            this.Footer_seperator.Size = new System.Drawing.Size(639, 1);
            this.Footer_seperator.TabIndex = 50;
            // 
            // about_tool
            // 
            this.about_tool.AutoSize = true;
            this.about_tool.BackColor = System.Drawing.Color.Transparent;
            this.about_tool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about_tool.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_tool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.about_tool.Location = new System.Drawing.Point(9, 10);
            this.about_tool.Name = "about_tool";
            this.about_tool.Size = new System.Drawing.Size(87, 18);
            this.about_tool.TabIndex = 47;
            this.about_tool.Text = "ABOUT TOOL";
            this.about_tool.Click += new System.EventHandler(this.about_tool_Click);
            // 
            // link_ets2mp
            // 
            this.link_ets2mp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.link_ets2mp.AutoSize = true;
            this.link_ets2mp.BackColor = System.Drawing.Color.Transparent;
            this.link_ets2mp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_ets2mp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_ets2mp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.link_ets2mp.Location = new System.Drawing.Point(422, 10);
            this.link_ets2mp.Name = "link_ets2mp";
            this.link_ets2mp.Size = new System.Drawing.Size(204, 18);
            this.link_ets2mp.TabIndex = 48;
            this.link_ets2mp.Text = "TRUCKERSMP OFFICIAL WEBSITE";
            this.link_ets2mp.Click += new System.EventHandler(this.link_ets2mp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TruckersMP UI Changer";
            // 
            // ets_browse
            // 
            this.ets_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ets_browse.Location = new System.Drawing.Point(547, 102);
            this.ets_browse.Name = "ets_browse";
            this.ets_browse.Size = new System.Drawing.Size(79, 27);
            this.ets_browse.TabIndex = 64;
            this.ets_browse.Text = "Browse";
            this.ets_browse.UseVisualStyleBackColor = true;
            this.ets_browse.Click += new System.EventHandler(this.ets_browse_Click);
            // 
            // ats_browse
            // 
            this.ats_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_browse.Location = new System.Drawing.Point(547, 163);
            this.ats_browse.Name = "ats_browse";
            this.ats_browse.Size = new System.Drawing.Size(79, 26);
            this.ats_browse.TabIndex = 65;
            this.ats_browse.Text = "Browse";
            this.ats_browse.UseVisualStyleBackColor = true;
            this.ats_browse.Click += new System.EventHandler(this.ats_browse_Click);
            // 
            // ats_file
            // 
            this.ats_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_file.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.ats_file.Location = new System.Drawing.Point(18, 163);
            this.ats_file.Name = "ats_file";
            this.ats_file.Size = new System.Drawing.Size(523, 26);
            this.ats_file.TabIndex = 66;
            // 
            // ets_file
            // 
            this.ets_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ets_file.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.ets_file.Location = new System.Drawing.Point(18, 103);
            this.ets_file.Name = "ets_file";
            this.ets_file.Size = new System.Drawing.Size(523, 26);
            this.ets_file.TabIndex = 67;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.Label4.Location = new System.Drawing.Point(15, 82);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(275, 18);
            this.Label4.TabIndex = 68;
            this.Label4.Text = "UI Skin file to load for ETS2MP (ui_skin.png)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "UI Skin file to load for ATSMP (ui_skin.png)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel1.Location = new System.Drawing.Point(12, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 1);
            this.panel1.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 26);
            this.button1.TabIndex = 70;
            this.button1.Text = "Reset to default skins";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(506, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 26);
            this.button2.TabIndex = 71;
            this.button2.Text = "Install custom skin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 26);
            this.button4.TabIndex = 73;
            this.button4.Text = "Extract ETS ui_skin file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(484, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 26);
            this.button3.TabIndex = 74;
            this.button3.Text = "Extract ATS ui_skin file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 316);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ets_file);
            this.Controls.Add(this.ats_file);
            this.Controls.Add(this.ats_browse);
            this.Controls.Add(this.ets_browse);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.Footer_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TruckersMP UI Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            this.Footer_Panel.ResumeLayout(false);
            this.Footer_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Footer_Panel;
        private System.Windows.Forms.Panel Footer_seperator;
        internal System.Windows.Forms.Label about_tool;
        internal System.Windows.Forms.Label link_ets2mp;
        private System.Windows.Forms.Button ets_browse;
        private System.Windows.Forms.Button ats_browse;
        private System.Windows.Forms.TextBox ats_file;
        private System.Windows.Forms.TextBox ets_file;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

