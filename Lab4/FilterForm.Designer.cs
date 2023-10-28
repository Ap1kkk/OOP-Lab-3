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
            this.FilterTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FilterTableLayout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(951, 452);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FilterTableLayout
            // 
            this.FilterTableLayout.ColumnCount = 7;
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.Location = new System.Drawing.Point(3, 3);
            this.FilterTableLayout.Name = "FilterTableLayout";
            this.FilterTableLayout.RowCount = 1;
            this.FilterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterTableLayout.Size = new System.Drawing.Size(936, 237);
            this.FilterTableLayout.TabIndex = 9;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(741, 447);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(201, 33);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 490);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TableLayoutPanel FilterTableLayout;
    }
}