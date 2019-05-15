namespace Kactus
{
    partial class sitesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.siteSearchBox = new System.Windows.Forms.Label();
            this.siteSearchTextBox = new System.Windows.Forms.TextBox();
            this.addSiteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.siteUrlTextBox = new System.Windows.Forms.TextBox();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.groupIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(0, 70);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 180);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // siteSearchBox
            // 
            this.siteSearchBox.AutoSize = true;
            this.siteSearchBox.Location = new System.Drawing.Point(180, 80);
            this.siteSearchBox.Name = "siteSearchBox";
            this.siteSearchBox.Size = new System.Drawing.Size(0, 13);
            this.siteSearchBox.TabIndex = 2;
            // 
            // siteSearchTextBox
            // 
            this.siteSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.siteSearchTextBox.Location = new System.Drawing.Point(300, 25);
            this.siteSearchTextBox.Name = "siteSearchTextBox";
            this.siteSearchTextBox.Size = new System.Drawing.Size(200, 20);
            this.siteSearchTextBox.TabIndex = 3;
            this.siteSearchTextBox.Text = "Search My Vault";
            this.siteSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siteSearchTextBox_KeyPress);
            // 
            // addSiteButton
            // 
            this.addSiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.addSiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSiteButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addSiteButton.Location = new System.Drawing.Point(55, 275);
            this.addSiteButton.Name = "addSiteButton";
            this.addSiteButton.Size = new System.Drawing.Size(100, 23);
            this.addSiteButton.TabIndex = 4;
            this.addSiteButton.Text = "Add Site";
            this.addSiteButton.UseVisualStyleBackColor = false;
            this.addSiteButton.Click += new System.EventHandler(this.addSiteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.updateButton.Location = new System.Drawing.Point(250, 275);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deleteButton.Location = new System.Drawing.Point(450, 275);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clearButton.Location = new System.Drawing.Point(651, 275);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // siteUrlTextBox
            // 
            this.siteUrlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.siteUrlTextBox.Location = new System.Drawing.Point(566, 371);
            this.siteUrlTextBox.Name = "siteUrlTextBox";
            this.siteUrlTextBox.Size = new System.Drawing.Size(100, 20);
            this.siteUrlTextBox.TabIndex = 10;
            this.siteUrlTextBox.Text = "Site Url";
            // 
            // siteTextBox
            // 
            this.siteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.siteTextBox.Location = new System.Drawing.Point(134, 371);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(100, 20);
            this.siteTextBox.TabIndex = 12;
            this.siteTextBox.Text = "Site Name";
            this.siteTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.usernameTextBox.Location = new System.Drawing.Point(134, 444);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 13;
            this.usernameTextBox.Text = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.passwordTextBox.Location = new System.Drawing.Point(566, 444);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 14;
            this.passwordTextBox.Text = "Password";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.groupNameTextBox.Location = new System.Drawing.Point(566, 521);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.groupNameTextBox.TabIndex = 18;
            this.groupNameTextBox.Text = "Group Name";
            // 
            // groupIDTextBox
            // 
            this.groupIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.groupIDTextBox.Location = new System.Drawing.Point(134, 521);
            this.groupIDTextBox.Name = "groupIDTextBox";
            this.groupIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.groupIDTextBox.TabIndex = 19;
            this.groupIDTextBox.Text = "Group ID";
            // 
            // sitesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupIDTextBox);
            this.Controls.Add(this.groupNameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(this.siteUrlTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addSiteButton);
            this.Controls.Add(this.siteSearchTextBox);
            this.Controls.Add(this.siteSearchBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "sitesUserControl";
            this.Size = new System.Drawing.Size(800, 563);
            this.Load += new System.EventHandler(this.sitesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label siteSearchBox;
        private System.Windows.Forms.TextBox siteSearchTextBox;
        private System.Windows.Forms.Button addSiteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox siteUrlTextBox;
        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.TextBox groupIDTextBox;
    }
}
