namespace Lab4
{
    partial class FieldSelectForm
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
            this.FieldSelectPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FieldSelectPanel
            // 
            this.FieldSelectPanel.AutoScroll = true;
            this.FieldSelectPanel.AutoSize = true;
            this.FieldSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.FieldSelectPanel.Name = "FieldSelectPanel";
            this.FieldSelectPanel.Size = new System.Drawing.Size(800, 198);
            this.FieldSelectPanel.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(713, 163);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 15;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // FieldSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 198);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.FieldSelectPanel);
            this.Name = "FieldSelectForm";
            this.Text = "FieldSelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FieldSelectPanel;
        private System.Windows.Forms.Button ApplyButton;
    }
}