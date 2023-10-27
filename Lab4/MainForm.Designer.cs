namespace Lab4
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactsTabPage = new System.Windows.Forms.TabPage();
            this.SubFirmsTabPage = new System.Windows.Forms.TabPage();
            this.FirmsTabPage = new System.Windows.Forms.TabPage();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.subFirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IsMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bossNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BossName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officialBossNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.ContactsTabPage.SuspendLayout();
            this.SubFirmsTabPage.SuspendLayout();
            this.FirmsTabPage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFirmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "&Filter";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // ContactsTabPage
            // 
            this.ContactsTabPage.Controls.Add(this.dataGridView3);
            this.ContactsTabPage.Location = new System.Drawing.Point(4, 29);
            this.ContactsTabPage.Name = "ContactsTabPage";
            this.ContactsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ContactsTabPage.Size = new System.Drawing.Size(1082, 625);
            this.ContactsTabPage.TabIndex = 2;
            this.ContactsTabPage.Text = "Contacts";
            this.ContactsTabPage.UseVisualStyleBackColor = true;
            // 
            // SubFirmsTabPage
            // 
            this.SubFirmsTabPage.Controls.Add(this.dataGridView2);
            this.SubFirmsTabPage.Location = new System.Drawing.Point(4, 29);
            this.SubFirmsTabPage.Name = "SubFirmsTabPage";
            this.SubFirmsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.SubFirmsTabPage.Size = new System.Drawing.Size(1082, 625);
            this.SubFirmsTabPage.TabIndex = 1;
            this.SubFirmsTabPage.Text = "SubFirms";
            this.SubFirmsTabPage.UseVisualStyleBackColor = true;
            // 
            // FirmsTabPage
            // 
            this.FirmsTabPage.Controls.Add(this.dataGridView1);
            this.FirmsTabPage.Location = new System.Drawing.Point(4, 29);
            this.FirmsTabPage.Name = "FirmsTabPage";
            this.FirmsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.FirmsTabPage.Size = new System.Drawing.Size(1082, 625);
            this.FirmsTabPage.TabIndex = 0;
            this.FirmsTabPage.Text = "Firms";
            this.FirmsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.FirmsTabPage);
            this.MainTabControl.Controls.Add(this.SubFirmsTabPage);
            this.MainTabControl.Controls.Add(this.ContactsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1090, 658);
            this.MainTabControl.TabIndex = 3;
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataSource = typeof(Lab_3.Firm);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactsAmountDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.postIndexDataGridViewTextBoxColumn,
            this.websiteUrlDataGridViewTextBoxColumn,
            this.enterDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 619);
            this.dataGridView1.TabIndex = 0;
            // 
            // firmBindingSource1
            // 
            this.firmBindingSource1.DataSource = typeof(Lab_3.Firm);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 76;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 73;
            // 
            // contactsAmountDataGridViewTextBoxColumn
            // 
            this.contactsAmountDataGridViewTextBoxColumn.DataPropertyName = "ContactsAmount";
            this.contactsAmountDataGridViewTextBoxColumn.HeaderText = "ContactsAmount";
            this.contactsAmountDataGridViewTextBoxColumn.Name = "contactsAmountDataGridViewTextBoxColumn";
            this.contactsAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactsAmountDataGridViewTextBoxColumn.Width = 154;
            // 
            // enterDateDataGridViewTextBoxColumn
            // 
            this.enterDateDataGridViewTextBoxColumn.DataPropertyName = "EnterDate";
            this.enterDateDataGridViewTextBoxColumn.HeaderText = "EnterDate";
            this.enterDateDataGridViewTextBoxColumn.Name = "enterDateDataGridViewTextBoxColumn";
            this.enterDateDataGridViewTextBoxColumn.Width = 108;
            // 
            // websiteUrlDataGridViewTextBoxColumn
            // 
            this.websiteUrlDataGridViewTextBoxColumn.DataPropertyName = "WebsiteUrl";
            this.websiteUrlDataGridViewTextBoxColumn.HeaderText = "WebsiteUrl";
            this.websiteUrlDataGridViewTextBoxColumn.Name = "websiteUrlDataGridViewTextBoxColumn";
            this.websiteUrlDataGridViewTextBoxColumn.Width = 112;
            // 
            // postIndexDataGridViewTextBoxColumn
            // 
            this.postIndexDataGridViewTextBoxColumn.DataPropertyName = "PostIndex";
            this.postIndexDataGridViewTextBoxColumn.HeaderText = "PostIndex";
            this.postIndexDataGridViewTextBoxColumn.Name = "postIndexDataGridViewTextBoxColumn";
            this.postIndexDataGridViewTextBoxColumn.Width = 105;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 78;
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Town";
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            this.townDataGridViewTextBoxColumn.Width = 72;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.Width = 85;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 89;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1076, 619);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsMain,
            this.nameDataGridViewTextBoxColumn1,
            this.bossNameDataGridViewTextBoxColumn,
            this.BossName,
            this.officialBossNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.contactsAmountDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.subFirmBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.Size = new System.Drawing.Size(1076, 619);
            this.dataGridView2.TabIndex = 1;
            // 
            // subFirmBindingSource
            // 
            this.subFirmBindingSource.DataSource = typeof(Lab_3.SubFirm);
            // 
            // IsMain
            // 
            this.IsMain.DataPropertyName = "IsMain";
            this.IsMain.HeaderText = "IsMain";
            this.IsMain.Name = "IsMain";
            this.IsMain.Width = 81;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 76;
            // 
            // bossNameDataGridViewTextBoxColumn
            // 
            this.bossNameDataGridViewTextBoxColumn.DataPropertyName = "BossName";
            this.bossNameDataGridViewTextBoxColumn.HeaderText = "BossName";
            this.bossNameDataGridViewTextBoxColumn.Name = "bossNameDataGridViewTextBoxColumn";
            this.bossNameDataGridViewTextBoxColumn.Width = 112;
            // 
            // BossName
            // 
            this.BossName.DataPropertyName = "BossName";
            this.BossName.HeaderText = "BossName";
            this.BossName.Name = "BossName";
            this.BossName.Width = 112;
            // 
            // officialBossNameDataGridViewTextBoxColumn
            // 
            this.officialBossNameDataGridViewTextBoxColumn.DataPropertyName = "OfficialBossName";
            this.officialBossNameDataGridViewTextBoxColumn.HeaderText = "OfficialBossName";
            this.officialBossNameDataGridViewTextBoxColumn.Name = "officialBossNameDataGridViewTextBoxColumn";
            this.officialBossNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 136;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 73;
            // 
            // contactsAmountDataGridViewTextBoxColumn1
            // 
            this.contactsAmountDataGridViewTextBoxColumn1.DataPropertyName = "ContactsAmount";
            this.contactsAmountDataGridViewTextBoxColumn1.HeaderText = "ContactsAmount";
            this.contactsAmountDataGridViewTextBoxColumn1.Name = "contactsAmountDataGridViewTextBoxColumn1";
            this.contactsAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.contactsAmountDataGridViewTextBoxColumn1.Width = 154;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 682);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ContactsTabPage.ResumeLayout(false);
            this.SubFirmsTabPage.ResumeLayout(false);
            this.FirmsTabPage.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFirmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.TabPage ContactsTabPage;
        private System.Windows.Forms.TabPage SubFirmsTabPage;
        private System.Windows.Forms.TabPage FirmsTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource firmBindingSource1;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource subFirmBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bossNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BossName;
        private System.Windows.Forms.DataGridViewTextBoxColumn officialBossNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactsAmountDataGridViewTextBoxColumn1;
    }
}