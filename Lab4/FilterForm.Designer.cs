namespace Lab4
{
    partial class FilterForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirmNameSearch = new System.Windows.Forms.TextBox();
            this.FirmNameNotContains = new System.Windows.Forms.CheckBox();
            this.FirmNameContains = new System.Windows.Forms.CheckBox();
            this.FirmNameNotEquals = new System.Windows.Forms.CheckBox();
            this.FirmNameEquals = new System.Windows.Forms.CheckBox();
            this.FirmNameFilter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EnterDateGreater = new System.Windows.Forms.CheckBox();
            this.EnterDateLess = new System.Windows.Forms.CheckBox();
            this.EnterDateSearch = new System.Windows.Forms.DateTimePicker();
            this.EnterDateNotEquals = new System.Windows.Forms.CheckBox();
            this.EnterDateEquals = new System.Windows.Forms.CheckBox();
            this.EnterDateFilter = new System.Windows.Forms.CheckBox();
            this.EnterDateLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ContactsAmountSearch = new System.Windows.Forms.DomainUpDown();
            this.ContactsAmountGreater = new System.Windows.Forms.CheckBox();
            this.ContactsAmountLess = new System.Windows.Forms.CheckBox();
            this.ContactsAmountNotEquals = new System.Windows.Forms.CheckBox();
            this.ContactsAmountEquals = new System.Windows.Forms.CheckBox();
            this.ContactsAmountFilter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CountrySearch = new System.Windows.Forms.TextBox();
            this.CountryNotContains = new System.Windows.Forms.CheckBox();
            this.CountryContains = new System.Windows.Forms.CheckBox();
            this.CountryNotEquals = new System.Windows.Forms.CheckBox();
            this.CountryEquals = new System.Windows.Forms.CheckBox();
            this.CountryFilter = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RegionSearch = new System.Windows.Forms.TextBox();
            this.RegionNotContains = new System.Windows.Forms.CheckBox();
            this.RegionContains = new System.Windows.Forms.CheckBox();
            this.RegionNotEquals = new System.Windows.Forms.CheckBox();
            this.RegionEquals = new System.Windows.Forms.CheckBox();
            this.RegionFilter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(951, 452);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.FirmNameSearch);
            this.panel1.Controls.Add(this.FirmNameNotContains);
            this.panel1.Controls.Add(this.FirmNameContains);
            this.panel1.Controls.Add(this.FirmNameNotEquals);
            this.panel1.Controls.Add(this.FirmNameEquals);
            this.panel1.Controls.Add(this.FirmNameFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 46);
            this.panel1.TabIndex = 0;
            // 
            // FirmNameSearch
            // 
            this.FirmNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirmNameSearch.Location = new System.Drawing.Point(115, 6);
            this.FirmNameSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirmNameSearch.Name = "FirmNameSearch";
            this.FirmNameSearch.Size = new System.Drawing.Size(146, 26);
            this.FirmNameSearch.TabIndex = 6;
            this.FirmNameSearch.Text = "search value";
            this.FirmNameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirmNameSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirmNameNotContains
            // 
            this.FirmNameNotContains.AutoSize = true;
            this.FirmNameNotContains.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirmNameNotContains.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirmNameNotContains.Enabled = false;
            this.FirmNameNotContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirmNameNotContains.Location = new System.Drawing.Point(542, 9);
            this.FirmNameNotContains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirmNameNotContains.Name = "FirmNameNotContains";
            this.FirmNameNotContains.Size = new System.Drawing.Size(133, 28);
            this.FirmNameNotContains.TabIndex = 5;
            this.FirmNameNotContains.Text = "Not contains";
            this.FirmNameNotContains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirmNameNotContains.UseVisualStyleBackColor = true;
            // 
            // FirmNameContains
            // 
            this.FirmNameContains.AutoSize = true;
            this.FirmNameContains.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirmNameContains.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirmNameContains.Enabled = false;
            this.FirmNameContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirmNameContains.Location = new System.Drawing.Point(440, 9);
            this.FirmNameContains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirmNameContains.Name = "FirmNameContains";
            this.FirmNameContains.Size = new System.Drawing.Size(102, 28);
            this.FirmNameContains.TabIndex = 4;
            this.FirmNameContains.Text = "Contains";
            this.FirmNameContains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirmNameContains.UseVisualStyleBackColor = true;
            // 
            // FirmNameNotEquals
            // 
            this.FirmNameNotEquals.AutoSize = true;
            this.FirmNameNotEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirmNameNotEquals.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirmNameNotEquals.Enabled = false;
            this.FirmNameNotEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirmNameNotEquals.Location = new System.Drawing.Point(394, 9);
            this.FirmNameNotEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirmNameNotEquals.Name = "FirmNameNotEquals";
            this.FirmNameNotEquals.Size = new System.Drawing.Size(45, 28);
            this.FirmNameNotEquals.TabIndex = 3;
            this.FirmNameNotEquals.Text = "!=";
            this.FirmNameNotEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirmNameNotEquals.UseVisualStyleBackColor = true;
            // 
            // FirmNameEquals
            // 
            this.FirmNameEquals.AutoSize = true;
            this.FirmNameEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirmNameEquals.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirmNameEquals.Enabled = false;
            this.FirmNameEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirmNameEquals.Location = new System.Drawing.Point(343, 9);
            this.FirmNameEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirmNameEquals.Name = "FirmNameEquals";
            this.FirmNameEquals.Size = new System.Drawing.Size(51, 28);
            this.FirmNameEquals.TabIndex = 2;
            this.FirmNameEquals.Text = "==";
            this.FirmNameEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirmNameEquals.UseVisualStyleBackColor = true;
            this.FirmNameEquals.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FirmNameFilter
            // 
            this.FirmNameFilter.AutoSize = true;
            this.FirmNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirmNameFilter.Location = new System.Drawing.Point(278, 9);
            this.FirmNameFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirmNameFilter.Name = "FirmNameFilter";
            this.FirmNameFilter.Size = new System.Drawing.Size(62, 28);
            this.FirmNameFilter.TabIndex = 1;
            this.FirmNameFilter.Text = "filter";
            this.FirmNameFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirmNameFilter.UseVisualStyleBackColor = true;
            this.FirmNameFilter.CheckedChanged += new System.EventHandler(this.FirmNameFilter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firm Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.EnterDateGreater);
            this.panel2.Controls.Add(this.EnterDateLess);
            this.panel2.Controls.Add(this.EnterDateSearch);
            this.panel2.Controls.Add(this.EnterDateNotEquals);
            this.panel2.Controls.Add(this.EnterDateEquals);
            this.panel2.Controls.Add(this.EnterDateFilter);
            this.panel2.Controls.Add(this.EnterDateLabel);
            this.panel2.Location = new System.Drawing.Point(2, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 46);
            this.panel2.TabIndex = 7;
            // 
            // EnterDateGreater
            // 
            this.EnterDateGreater.AutoSize = true;
            this.EnterDateGreater.Enabled = false;
            this.EnterDateGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDateGreater.Location = new System.Drawing.Point(542, 9);
            this.EnterDateGreater.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterDateGreater.Name = "EnterDateGreater";
            this.EnterDateGreater.Size = new System.Drawing.Size(40, 28);
            this.EnterDateGreater.TabIndex = 5;
            this.EnterDateGreater.Text = ">";
            this.EnterDateGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterDateGreater.UseVisualStyleBackColor = true;
            // 
            // EnterDateLess
            // 
            this.EnterDateLess.AutoSize = true;
            this.EnterDateLess.Enabled = false;
            this.EnterDateLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDateLess.Location = new System.Drawing.Point(440, 9);
            this.EnterDateLess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterDateLess.Name = "EnterDateLess";
            this.EnterDateLess.Size = new System.Drawing.Size(40, 28);
            this.EnterDateLess.TabIndex = 4;
            this.EnterDateLess.Text = "<";
            this.EnterDateLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterDateLess.UseVisualStyleBackColor = true;
            // 
            // EnterDateSearch
            // 
            this.EnterDateSearch.Location = new System.Drawing.Point(115, 10);
            this.EnterDateSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterDateSearch.Name = "EnterDateSearch";
            this.EnterDateSearch.Size = new System.Drawing.Size(151, 20);
            this.EnterDateSearch.TabIndex = 7;
            // 
            // EnterDateNotEquals
            // 
            this.EnterDateNotEquals.AutoSize = true;
            this.EnterDateNotEquals.Enabled = false;
            this.EnterDateNotEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDateNotEquals.Location = new System.Drawing.Point(394, 9);
            this.EnterDateNotEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterDateNotEquals.Name = "EnterDateNotEquals";
            this.EnterDateNotEquals.Size = new System.Drawing.Size(45, 28);
            this.EnterDateNotEquals.TabIndex = 3;
            this.EnterDateNotEquals.Text = "!=";
            this.EnterDateNotEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterDateNotEquals.UseVisualStyleBackColor = true;
            // 
            // EnterDateEquals
            // 
            this.EnterDateEquals.AutoSize = true;
            this.EnterDateEquals.Enabled = false;
            this.EnterDateEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDateEquals.Location = new System.Drawing.Point(343, 9);
            this.EnterDateEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterDateEquals.Name = "EnterDateEquals";
            this.EnterDateEquals.Size = new System.Drawing.Size(51, 28);
            this.EnterDateEquals.TabIndex = 2;
            this.EnterDateEquals.Text = "==";
            this.EnterDateEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterDateEquals.UseVisualStyleBackColor = true;
            // 
            // EnterDateFilter
            // 
            this.EnterDateFilter.AutoSize = true;
            this.EnterDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDateFilter.Location = new System.Drawing.Point(278, 9);
            this.EnterDateFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterDateFilter.Name = "EnterDateFilter";
            this.EnterDateFilter.Size = new System.Drawing.Size(62, 28);
            this.EnterDateFilter.TabIndex = 1;
            this.EnterDateFilter.Text = "filter";
            this.EnterDateFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterDateFilter.UseVisualStyleBackColor = true;
            // 
            // EnterDateLabel
            // 
            this.EnterDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterDateLabel.Location = new System.Drawing.Point(2, 9);
            this.EnterDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterDateLabel.Name = "EnterDateLabel";
            this.EnterDateLabel.Size = new System.Drawing.Size(108, 19);
            this.EnterDateLabel.TabIndex = 0;
            this.EnterDateLabel.Text = "Enter date";
            this.EnterDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.ContactsAmountSearch);
            this.panel3.Controls.Add(this.ContactsAmountGreater);
            this.panel3.Controls.Add(this.ContactsAmountLess);
            this.panel3.Controls.Add(this.ContactsAmountNotEquals);
            this.panel3.Controls.Add(this.ContactsAmountEquals);
            this.panel3.Controls.Add(this.ContactsAmountFilter);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(2, 102);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 46);
            this.panel3.TabIndex = 8;
            // 
            // ContactsAmountSearch
            // 
            this.ContactsAmountSearch.Location = new System.Drawing.Point(136, 12);
            this.ContactsAmountSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactsAmountSearch.Name = "ContactsAmountSearch";
            this.ContactsAmountSearch.Size = new System.Drawing.Size(129, 20);
            this.ContactsAmountSearch.TabIndex = 6;
            this.ContactsAmountSearch.Text = "search value";
            // 
            // ContactsAmountGreater
            // 
            this.ContactsAmountGreater.AutoSize = true;
            this.ContactsAmountGreater.Enabled = false;
            this.ContactsAmountGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAmountGreater.Location = new System.Drawing.Point(542, 9);
            this.ContactsAmountGreater.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactsAmountGreater.Name = "ContactsAmountGreater";
            this.ContactsAmountGreater.Size = new System.Drawing.Size(40, 28);
            this.ContactsAmountGreater.TabIndex = 5;
            this.ContactsAmountGreater.Text = ">";
            this.ContactsAmountGreater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContactsAmountGreater.UseVisualStyleBackColor = true;
            // 
            // ContactsAmountLess
            // 
            this.ContactsAmountLess.AutoSize = true;
            this.ContactsAmountLess.Enabled = false;
            this.ContactsAmountLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAmountLess.Location = new System.Drawing.Point(440, 9);
            this.ContactsAmountLess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactsAmountLess.Name = "ContactsAmountLess";
            this.ContactsAmountLess.Size = new System.Drawing.Size(40, 28);
            this.ContactsAmountLess.TabIndex = 4;
            this.ContactsAmountLess.Text = "<";
            this.ContactsAmountLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContactsAmountLess.UseVisualStyleBackColor = true;
            // 
            // ContactsAmountNotEquals
            // 
            this.ContactsAmountNotEquals.AutoSize = true;
            this.ContactsAmountNotEquals.Enabled = false;
            this.ContactsAmountNotEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAmountNotEquals.Location = new System.Drawing.Point(394, 9);
            this.ContactsAmountNotEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactsAmountNotEquals.Name = "ContactsAmountNotEquals";
            this.ContactsAmountNotEquals.Size = new System.Drawing.Size(45, 28);
            this.ContactsAmountNotEquals.TabIndex = 3;
            this.ContactsAmountNotEquals.Text = "!=";
            this.ContactsAmountNotEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContactsAmountNotEquals.UseVisualStyleBackColor = true;
            // 
            // ContactsAmountEquals
            // 
            this.ContactsAmountEquals.AutoSize = true;
            this.ContactsAmountEquals.Enabled = false;
            this.ContactsAmountEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAmountEquals.Location = new System.Drawing.Point(343, 9);
            this.ContactsAmountEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactsAmountEquals.Name = "ContactsAmountEquals";
            this.ContactsAmountEquals.Size = new System.Drawing.Size(51, 28);
            this.ContactsAmountEquals.TabIndex = 2;
            this.ContactsAmountEquals.Text = "==";
            this.ContactsAmountEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContactsAmountEquals.UseVisualStyleBackColor = true;
            // 
            // ContactsAmountFilter
            // 
            this.ContactsAmountFilter.AutoSize = true;
            this.ContactsAmountFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAmountFilter.Location = new System.Drawing.Point(278, 9);
            this.ContactsAmountFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactsAmountFilter.Name = "ContactsAmountFilter";
            this.ContactsAmountFilter.Size = new System.Drawing.Size(62, 28);
            this.ContactsAmountFilter.TabIndex = 1;
            this.ContactsAmountFilter.Text = "filter";
            this.ContactsAmountFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContactsAmountFilter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contacts amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.CountrySearch);
            this.panel4.Controls.Add(this.CountryNotContains);
            this.panel4.Controls.Add(this.CountryContains);
            this.panel4.Controls.Add(this.CountryNotEquals);
            this.panel4.Controls.Add(this.CountryEquals);
            this.panel4.Controls.Add(this.CountryFilter);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(2, 152);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(949, 46);
            this.panel4.TabIndex = 9;
            // 
            // CountrySearch
            // 
            this.CountrySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountrySearch.Location = new System.Drawing.Point(115, 6);
            this.CountrySearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountrySearch.Name = "CountrySearch";
            this.CountrySearch.Size = new System.Drawing.Size(146, 26);
            this.CountrySearch.TabIndex = 6;
            this.CountrySearch.Text = "search value";
            this.CountrySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountryNotContains
            // 
            this.CountryNotContains.AutoSize = true;
            this.CountryNotContains.Enabled = false;
            this.CountryNotContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryNotContains.Location = new System.Drawing.Point(542, 9);
            this.CountryNotContains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryNotContains.Name = "CountryNotContains";
            this.CountryNotContains.Size = new System.Drawing.Size(133, 28);
            this.CountryNotContains.TabIndex = 5;
            this.CountryNotContains.Text = "Not contains";
            this.CountryNotContains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountryNotContains.UseVisualStyleBackColor = true;
            // 
            // CountryContains
            // 
            this.CountryContains.AutoSize = true;
            this.CountryContains.Enabled = false;
            this.CountryContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryContains.Location = new System.Drawing.Point(440, 9);
            this.CountryContains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryContains.Name = "CountryContains";
            this.CountryContains.Size = new System.Drawing.Size(102, 28);
            this.CountryContains.TabIndex = 4;
            this.CountryContains.Text = "Contains";
            this.CountryContains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountryContains.UseVisualStyleBackColor = true;
            // 
            // CountryNotEquals
            // 
            this.CountryNotEquals.AutoSize = true;
            this.CountryNotEquals.Enabled = false;
            this.CountryNotEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryNotEquals.Location = new System.Drawing.Point(394, 9);
            this.CountryNotEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryNotEquals.Name = "CountryNotEquals";
            this.CountryNotEquals.Size = new System.Drawing.Size(45, 28);
            this.CountryNotEquals.TabIndex = 3;
            this.CountryNotEquals.Text = "!=";
            this.CountryNotEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountryNotEquals.UseVisualStyleBackColor = true;
            // 
            // CountryEquals
            // 
            this.CountryEquals.AutoSize = true;
            this.CountryEquals.Enabled = false;
            this.CountryEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryEquals.Location = new System.Drawing.Point(343, 9);
            this.CountryEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryEquals.Name = "CountryEquals";
            this.CountryEquals.Size = new System.Drawing.Size(51, 28);
            this.CountryEquals.TabIndex = 2;
            this.CountryEquals.Text = "==";
            this.CountryEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountryEquals.UseVisualStyleBackColor = true;
            // 
            // CountryFilter
            // 
            this.CountryFilter.AutoSize = true;
            this.CountryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryFilter.Location = new System.Drawing.Point(278, 9);
            this.CountryFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryFilter.Name = "CountryFilter";
            this.CountryFilter.Size = new System.Drawing.Size(62, 28);
            this.CountryFilter.TabIndex = 1;
            this.CountryFilter.Text = "filter";
            this.CountryFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountryFilter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Country";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.RegionSearch);
            this.panel5.Controls.Add(this.RegionNotContains);
            this.panel5.Controls.Add(this.RegionContains);
            this.panel5.Controls.Add(this.RegionNotEquals);
            this.panel5.Controls.Add(this.RegionEquals);
            this.panel5.Controls.Add(this.RegionFilter);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(2, 202);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(949, 46);
            this.panel5.TabIndex = 10;
            // 
            // RegionSearch
            // 
            this.RegionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionSearch.Location = new System.Drawing.Point(115, 6);
            this.RegionSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegionSearch.Name = "RegionSearch";
            this.RegionSearch.Size = new System.Drawing.Size(146, 26);
            this.RegionSearch.TabIndex = 6;
            this.RegionSearch.Text = "search value";
            this.RegionSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegionNotContains
            // 
            this.RegionNotContains.AutoSize = true;
            this.RegionNotContains.Enabled = false;
            this.RegionNotContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionNotContains.Location = new System.Drawing.Point(542, 6);
            this.RegionNotContains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegionNotContains.Name = "RegionNotContains";
            this.RegionNotContains.Size = new System.Drawing.Size(133, 28);
            this.RegionNotContains.TabIndex = 5;
            this.RegionNotContains.Text = "Not contains";
            this.RegionNotContains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegionNotContains.UseVisualStyleBackColor = true;
            // 
            // RegionContains
            // 
            this.RegionContains.AutoSize = true;
            this.RegionContains.Enabled = false;
            this.RegionContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionContains.Location = new System.Drawing.Point(440, 6);
            this.RegionContains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegionContains.Name = "RegionContains";
            this.RegionContains.Size = new System.Drawing.Size(102, 28);
            this.RegionContains.TabIndex = 4;
            this.RegionContains.Text = "Contains";
            this.RegionContains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegionContains.UseVisualStyleBackColor = true;
            // 
            // RegionNotEquals
            // 
            this.RegionNotEquals.AutoSize = true;
            this.RegionNotEquals.Enabled = false;
            this.RegionNotEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionNotEquals.Location = new System.Drawing.Point(394, 9);
            this.RegionNotEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegionNotEquals.Name = "RegionNotEquals";
            this.RegionNotEquals.Size = new System.Drawing.Size(45, 28);
            this.RegionNotEquals.TabIndex = 3;
            this.RegionNotEquals.Text = "!=";
            this.RegionNotEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegionNotEquals.UseVisualStyleBackColor = true;
            // 
            // RegionEquals
            // 
            this.RegionEquals.AutoSize = true;
            this.RegionEquals.Enabled = false;
            this.RegionEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionEquals.Location = new System.Drawing.Point(343, 9);
            this.RegionEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegionEquals.Name = "RegionEquals";
            this.RegionEquals.Size = new System.Drawing.Size(51, 28);
            this.RegionEquals.TabIndex = 2;
            this.RegionEquals.Text = "==";
            this.RegionEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegionEquals.UseVisualStyleBackColor = true;
            // 
            // RegionFilter
            // 
            this.RegionFilter.AutoSize = true;
            this.RegionFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionFilter.Location = new System.Drawing.Point(278, 9);
            this.RegionFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegionFilter.Name = "RegionFilter";
            this.RegionFilter.Size = new System.Drawing.Size(62, 28);
            this.RegionFilter.TabIndex = 1;
            this.RegionFilter.Text = "filter";
            this.RegionFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegionFilter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Region";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(741, 447);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(201, 33);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 490);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FirmNameEquals;
        private System.Windows.Forms.CheckBox FirmNameFilter;
        private System.Windows.Forms.CheckBox FirmNameNotEquals;
        private System.Windows.Forms.CheckBox FirmNameNotContains;
        private System.Windows.Forms.CheckBox FirmNameContains;
        private System.Windows.Forms.TextBox FirmNameSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox EnterDateGreater;
        private System.Windows.Forms.CheckBox EnterDateLess;
        private System.Windows.Forms.CheckBox EnterDateNotEquals;
        private System.Windows.Forms.CheckBox EnterDateEquals;
        private System.Windows.Forms.CheckBox EnterDateFilter;
        private System.Windows.Forms.Label EnterDateLabel;
        private System.Windows.Forms.DateTimePicker EnterDateSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DomainUpDown ContactsAmountSearch;
        private System.Windows.Forms.CheckBox ContactsAmountGreater;
        private System.Windows.Forms.CheckBox ContactsAmountLess;
        private System.Windows.Forms.CheckBox ContactsAmountNotEquals;
        private System.Windows.Forms.CheckBox ContactsAmountEquals;
        private System.Windows.Forms.CheckBox ContactsAmountFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox CountrySearch;
        private System.Windows.Forms.CheckBox CountryNotContains;
        private System.Windows.Forms.CheckBox CountryContains;
        private System.Windows.Forms.CheckBox CountryNotEquals;
        private System.Windows.Forms.CheckBox CountryEquals;
        private System.Windows.Forms.CheckBox CountryFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox RegionSearch;
        private System.Windows.Forms.CheckBox RegionNotContains;
        private System.Windows.Forms.CheckBox RegionContains;
        private System.Windows.Forms.CheckBox RegionNotEquals;
        private System.Windows.Forms.CheckBox RegionEquals;
        private System.Windows.Forms.CheckBox RegionFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ApplyButton;
    }
}