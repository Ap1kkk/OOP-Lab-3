namespace Lab4
{
    partial class AddFirmForm
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
            this.InputLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(977, 559);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(268, 41);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // InputLayoutPanel
            // 
            this.InputLayoutPanel.AutoScroll = true;
            this.InputLayoutPanel.AutoSize = true;
            this.InputLayoutPanel.ColumnCount = 3;
            this.InputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InputLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InputLayoutPanel.Location = new System.Drawing.Point(19, 54);
            this.InputLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputLayoutPanel.Name = "InputLayoutPanel";
            this.InputLayoutPanel.RowCount = 2;
            this.InputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputLayoutPanel.Size = new System.Drawing.Size(1146, 471);
            this.InputLayoutPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1153, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.InputLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddFirmForm";
            this.Text = "AddFirmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TableLayoutPanel InputLayoutPanel;
        private System.Windows.Forms.Label label1;
    }
}