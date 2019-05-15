namespace Kactus
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
            this.components = new System.ComponentModel.Container();
            this.titleBar = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.slidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.slidingPanel = new System.Windows.Forms.Panel();
            this.menuRetractButton = new System.Windows.Forms.Button();
            this.aboutRetractButton = new System.Windows.Forms.Button();
            this.sitesRetractButton = new System.Windows.Forms.Button();
            this.groupRetractButton = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.Button();
            this.sites = new System.Windows.Forms.Button();
            this.toggleButton = new System.Windows.Forms.Button();
            this.titleBar.SuspendLayout();
            this.slidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.titleBar.Controls.Add(this.logOut);
            this.titleBar.Controls.Add(this.minimize);
            this.titleBar.Controls.Add(this.close);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1000, 37);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // logOut
            // 
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.ForeColor = System.Drawing.Color.Transparent;
            this.logOut.Image = global::Kactus.Properties.Resources.sign_out;
            this.logOut.Location = new System.Drawing.Point(889, 3);
            this.logOut.Margin = new System.Windows.Forms.Padding(0);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(30, 29);
            this.logOut.TabIndex = 2;
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            this.logOut.MouseEnter += new System.EventHandler(this.logOut_MouseEnter);
            this.logOut.MouseLeave += new System.EventHandler(this.logOut_MouseLeave);
            this.logOut.MouseHover += new System.EventHandler(this.logOut_MouseHover);
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.Transparent;
            this.minimize.Image = global::Kactus.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(922, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 29);
            this.minimize.TabIndex = 3;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.Image = global::Kactus.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(958, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 29);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // slidingPanelTimer
            // 
            this.slidingPanelTimer.Tick += new System.EventHandler(this.slidingPanelTimer_Tick);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.BackgroundImage = global::Kactus.Properties.Resources.Min_cac_cont2;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentPanel.Location = new System.Drawing.Point(200, 37);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 563);
            this.contentPanel.TabIndex = 2;
            // 
            // slidingPanel
            // 
            this.slidingPanel.BackColor = System.Drawing.Color.Transparent;
            this.slidingPanel.BackgroundImage = global::Kactus.Properties.Resources.Min_cac_app_menu3;
            this.slidingPanel.Controls.Add(this.sitesRetractButton);
            this.slidingPanel.Controls.Add(this.sites);
            this.slidingPanel.Controls.Add(this.menuRetractButton);
            this.slidingPanel.Controls.Add(this.aboutRetractButton);
            this.slidingPanel.Controls.Add(this.groupRetractButton);
            this.slidingPanel.Controls.Add(this.about);
            this.slidingPanel.Controls.Add(this.group);
            this.slidingPanel.Controls.Add(this.toggleButton);
            this.slidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingPanel.ForeColor = System.Drawing.Color.Transparent;
            this.slidingPanel.Location = new System.Drawing.Point(0, 37);
            this.slidingPanel.Name = "slidingPanel";
            this.slidingPanel.Size = new System.Drawing.Size(200, 563);
            this.slidingPanel.TabIndex = 1;
            // 
            // menuRetractButton
            // 
            this.menuRetractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.menuRetractButton.Image = global::Kactus.Properties.Resources.menu_but2;
            this.menuRetractButton.Location = new System.Drawing.Point(0, 48);
            this.menuRetractButton.Name = "menuRetractButton";
            this.menuRetractButton.Size = new System.Drawing.Size(100, 75);
            this.menuRetractButton.TabIndex = 10;
            this.menuRetractButton.UseVisualStyleBackColor = false;
            this.menuRetractButton.Click += new System.EventHandler(this.menuRetractButton_Click);
            // 
            // aboutRetractButton
            // 
            this.aboutRetractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.aboutRetractButton.Image = global::Kactus.Properties.Resources.info_but2;
            this.aboutRetractButton.Location = new System.Drawing.Point(0, 261);
            this.aboutRetractButton.Name = "aboutRetractButton";
            this.aboutRetractButton.Size = new System.Drawing.Size(100, 75);
            this.aboutRetractButton.TabIndex = 9;
            this.aboutRetractButton.UseVisualStyleBackColor = false;
            this.aboutRetractButton.Click += new System.EventHandler(this.aboutRetractButton_Click);
            // 
            // sitesRetractButton
            // 
            this.sitesRetractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.sitesRetractButton.Image = global::Kactus.Properties.Resources.sites_but2;
            this.sitesRetractButton.Location = new System.Drawing.Point(0, 180);
            this.sitesRetractButton.Name = "sitesRetractButton";
            this.sitesRetractButton.Size = new System.Drawing.Size(100, 75);
            this.sitesRetractButton.TabIndex = 8;
            this.sitesRetractButton.UseVisualStyleBackColor = false;
            this.sitesRetractButton.Click += new System.EventHandler(this.sitesRetractButton_Click);
            // 
            // groupRetractButton
            // 
            this.groupRetractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.groupRetractButton.Image = global::Kactus.Properties.Resources.group_but3;
            this.groupRetractButton.Location = new System.Drawing.Point(0, 342);
            this.groupRetractButton.Name = "groupRetractButton";
            this.groupRetractButton.Size = new System.Drawing.Size(100, 75);
            this.groupRetractButton.TabIndex = 7;
            this.groupRetractButton.UseVisualStyleBackColor = false;
            this.groupRetractButton.Click += new System.EventHandler(this.groupRetractButton_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.ForeColor = System.Drawing.Color.Black;
            this.about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about.Location = new System.Drawing.Point(12, 261);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(175, 75);
            this.about.TabIndex = 6;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.group.Cursor = System.Windows.Forms.Cursors.Default;
            this.group.FlatAppearance.BorderSize = 0;
            this.group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.ForeColor = System.Drawing.Color.Black;
            this.group.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.group.Location = new System.Drawing.Point(12, 342);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(175, 75);
            this.group.TabIndex = 5;
            this.group.Text = "Groups";
            this.group.UseVisualStyleBackColor = false;
            this.group.Click += new System.EventHandler(this.group_Click);
            // 
            // sites
            // 
            this.sites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.sites.FlatAppearance.BorderSize = 0;
            this.sites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sites.ForeColor = System.Drawing.Color.Black;
            this.sites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sites.Location = new System.Drawing.Point(12, 180);
            this.sites.Name = "sites";
            this.sites.Size = new System.Drawing.Size(175, 75);
            this.sites.TabIndex = 3;
            this.sites.Text = "Sites";
            this.sites.UseVisualStyleBackColor = false;
            this.sites.Click += new System.EventHandler(this.sites_Click);
            // 
            // toggleButton
            // 
            this.toggleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.toggleButton.FlatAppearance.BorderSize = 0;
            this.toggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton.ForeColor = System.Drawing.Color.Black;
            this.toggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toggleButton.Location = new System.Drawing.Point(0, 48);
            this.toggleButton.Margin = new System.Windows.Forms.Padding(0);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(200, 75);
            this.toggleButton.TabIndex = 2;
            this.toggleButton.Text = "Menu";
            this.toggleButton.UseVisualStyleBackColor = false;
            this.toggleButton.Click += new System.EventHandler(this.groups_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kactus.Properties.Resources.Min_cac_Main_pan2;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.slidingPanel);
            this.Controls.Add(this.titleBar);
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Kactus #2 Password Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.titleBar.ResumeLayout(false);
            this.slidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel slidingPanel;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Timer slidingPanelTimer;
        private System.Windows.Forms.Button group;
        private System.Windows.Forms.Button sites;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button groupRetractButton;
        private System.Windows.Forms.Button menuRetractButton;
        private System.Windows.Forms.Button aboutRetractButton;
        private System.Windows.Forms.Button sitesRetractButton;
        private System.Windows.Forms.Panel contentPanel;
    }
}