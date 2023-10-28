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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.FilterTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(988, 550);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(268, 41);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // FilterTableLayout
            // 
            this.FilterTableLayout.ColumnCount = 4;
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterTableLayout.Location = new System.Drawing.Point(0, 0);
            this.FilterTableLayout.Name = "FilterTableLayout";
            this.FilterTableLayout.RowCount = 2;
            this.FilterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterTableLayout.Size = new System.Drawing.Size(1268, 603);
            this.FilterTableLayout.TabIndex = 2;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 603);
            this.Controls.Add(this.FilterTableLayout);
            this.Controls.Add(this.ApplyButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TableLayoutPanel FilterTableLayout;
    }
}