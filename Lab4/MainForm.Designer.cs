﻿namespace Lab4
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubFirmsTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IsMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bossNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BossName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officialBossNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subFirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirmsTabPage = new System.Windows.Forms.TabPage();
            this.FirmsGridView = new System.Windows.Forms.DataGridView();
            this.firmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ContactsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SubFirmsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFirmBindingSource)).BeginInit();
            this.FirmsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirmsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource1)).BeginInit();
            this.MainTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.selectFieldsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1453, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.menuToolStripMenuItem.Text = "&Filter";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // ContactsTabPage
            // 
            this.ContactsTabPage.Controls.Add(this.dataGridView3);
            this.ContactsTabPage.Location = new System.Drawing.Point(4, 34);
            this.ContactsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ContactsTabPage.Name = "ContactsTabPage";
            this.ContactsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.ContactsTabPage.Size = new System.Drawing.Size(1445, 773);
            this.ContactsTabPage.TabIndex = 2;
            this.ContactsTabPage.Text = "Contacts";
            this.ContactsTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Note,
            this.descriptionDataGridViewTextBoxColumn,
            this.informationDataGridViewTextBoxColumn,
            this.beginDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.contactBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(4, 4);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.Size = new System.Drawing.Size(1437, 765);
            this.dataGridView3.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 76;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.Width = 68;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 114;
            // 
            // informationDataGridViewTextBoxColumn
            // 
            this.informationDataGridViewTextBoxColumn.DataPropertyName = "Information";
            this.informationDataGridViewTextBoxColumn.HeaderText = "Information";
            this.informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            this.informationDataGridViewTextBoxColumn.Width = 115;
            // 
            // beginDateDataGridViewTextBoxColumn
            // 
            this.beginDateDataGridViewTextBoxColumn.DataPropertyName = "BeginDate";
            this.beginDateDataGridViewTextBoxColumn.HeaderText = "BeginDate";
            this.beginDateDataGridViewTextBoxColumn.Name = "beginDateDataGridViewTextBoxColumn";
            this.beginDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 98;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(Lab_3.Contact);
            // 
            // SubFirmsTabPage
            // 
            this.SubFirmsTabPage.Controls.Add(this.dataGridView2);
            this.SubFirmsTabPage.Location = new System.Drawing.Point(4, 34);
            this.SubFirmsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.SubFirmsTabPage.Name = "SubFirmsTabPage";
            this.SubFirmsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.SubFirmsTabPage.Size = new System.Drawing.Size(1445, 773);
            this.SubFirmsTabPage.TabIndex = 1;
            this.SubFirmsTabPage.Text = "SubFirms";
            this.SubFirmsTabPage.UseVisualStyleBackColor = true;
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
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.Size = new System.Drawing.Size(1437, 765);
            this.dataGridView2.TabIndex = 1;
            // 
            // IsMain
            // 
            this.IsMain.DataPropertyName = "IsMain";
            this.IsMain.HeaderText = "IsMain";
            this.IsMain.MinimumWidth = 6;
            this.IsMain.Name = "IsMain";
            this.IsMain.Width = 99;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 93;
            // 
            // bossNameDataGridViewTextBoxColumn
            // 
            this.bossNameDataGridViewTextBoxColumn.DataPropertyName = "BossName";
            this.bossNameDataGridViewTextBoxColumn.HeaderText = "BossName";
            this.bossNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bossNameDataGridViewTextBoxColumn.Name = "bossNameDataGridViewTextBoxColumn";
            this.bossNameDataGridViewTextBoxColumn.Width = 137;
            // 
            // BossName
            // 
            this.BossName.DataPropertyName = "BossName";
            this.BossName.HeaderText = "BossName";
            this.BossName.MinimumWidth = 6;
            this.BossName.Name = "BossName";
            this.BossName.Width = 137;
            // 
            // officialBossNameDataGridViewTextBoxColumn
            // 
            this.officialBossNameDataGridViewTextBoxColumn.DataPropertyName = "OfficialBossName";
            this.officialBossNameDataGridViewTextBoxColumn.HeaderText = "OfficialBossName";
            this.officialBossNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.officialBossNameDataGridViewTextBoxColumn.Name = "officialBossNameDataGridViewTextBoxColumn";
            this.officialBossNameDataGridViewTextBoxColumn.Width = 196;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 167;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 89;
            // 
            // contactsAmountDataGridViewTextBoxColumn1
            // 
            this.contactsAmountDataGridViewTextBoxColumn1.DataPropertyName = "ContactsAmount";
            this.contactsAmountDataGridViewTextBoxColumn1.HeaderText = "ContactsAmount";
            this.contactsAmountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.contactsAmountDataGridViewTextBoxColumn1.Name = "contactsAmountDataGridViewTextBoxColumn1";
            this.contactsAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.contactsAmountDataGridViewTextBoxColumn1.Width = 187;
            // 
            // subFirmBindingSource
            // 
            this.subFirmBindingSource.DataSource = typeof(Lab_3.SubFirm);
            // 
            // FirmsTabPage
            // 
            this.FirmsTabPage.Controls.Add(this.FirmsGridView);
            this.FirmsTabPage.Location = new System.Drawing.Point(4, 34);
            this.FirmsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.FirmsTabPage.Name = "FirmsTabPage";
            this.FirmsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.FirmsTabPage.Size = new System.Drawing.Size(1445, 773);
            this.FirmsTabPage.TabIndex = 0;
            this.FirmsTabPage.Text = "Firms";
            this.FirmsTabPage.UseVisualStyleBackColor = true;
            // 
            // FirmsGridView
            // 
            this.FirmsGridView.AutoGenerateColumns = false;
            this.FirmsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FirmsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.FirmsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirmsGridView.DataSource = this.firmBindingSource1;
            this.FirmsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirmsGridView.Location = new System.Drawing.Point(4, 4);
            this.FirmsGridView.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.FirmsGridView.Name = "FirmsGridView";
            this.FirmsGridView.RowHeadersWidth = 51;
            this.FirmsGridView.RowTemplate.Height = 40;
            this.FirmsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirmsGridView.Size = new System.Drawing.Size(1437, 765);
            this.FirmsGridView.TabIndex = 0;
            // 
            // firmBindingSource1
            // 
            this.firmBindingSource1.DataSource = typeof(Lab_3.Firm);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.FirmsTabPage);
            this.MainTabControl.Controls.Add(this.SubFirmsTabPage);
            this.MainTabControl.Controls.Add(this.ContactsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabControl.Location = new System.Drawing.Point(0, 28);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1453, 811);
            this.MainTabControl.TabIndex = 3;
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataSource = typeof(Lab_3.Firm);
            // 
            // selectFieldsToolStripMenuItem
            // 
            this.selectFieldsToolStripMenuItem.Name = "selectFieldsToolStripMenuItem";
            this.selectFieldsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.selectFieldsToolStripMenuItem.Text = "&Select fields";
            this.selectFieldsToolStripMenuItem.Click += new System.EventHandler(this.selectFieldsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 839);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ContactsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.SubFirmsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFirmBindingSource)).EndInit();
            this.FirmsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirmsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource1)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView FirmsGridView;
        private System.Windows.Forms.BindingSource firmBindingSource1;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource subFirmBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bossNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BossName;
        private System.Windows.Forms.DataGridViewTextBoxColumn officialBossNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactsAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem selectFieldsToolStripMenuItem;
    }
}