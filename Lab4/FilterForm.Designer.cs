﻿namespace Lab4
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
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(776, 442);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(164, 37);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // FilterTableLayout
            // 
            this.FilterTableLayout.AutoScroll = true;
            this.FilterTableLayout.AutoSize = true;
            this.FilterTableLayout.ColumnCount = 4;
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.FilterTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.FilterTableLayout.Location = new System.Drawing.Point(2, 2);
            this.FilterTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterTableLayout.Name = "FilterTableLayout";
            this.FilterTableLayout.RowCount = 1;
            this.FilterTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilterTableLayout.Size = new System.Drawing.Size(0, 0);
            this.FilterTableLayout.TabIndex = 9;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 490);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.FilterTableLayout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TableLayoutPanel FilterTableLayout;
    }
}