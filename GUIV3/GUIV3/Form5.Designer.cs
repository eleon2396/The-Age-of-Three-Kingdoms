namespace GUIV3
{
    partial class Form5
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
            this.kingdomLabels = new System.Windows.Forms.Label();
            this.moreInfoButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kingdomLabels
            // 
            this.kingdomLabels.BackColor = System.Drawing.SystemColors.Info;
            this.kingdomLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kingdomLabels.Location = new System.Drawing.Point(342, 41);
            this.kingdomLabels.Name = "kingdomLabels";
            this.kingdomLabels.Size = new System.Drawing.Size(856, 82);
            this.kingdomLabels.TabIndex = 1;
            this.kingdomLabels.Text = "Background on Kingdoms";
            // 
            // moreInfoButton
            // 
            this.moreInfoButton.BackColor = System.Drawing.SystemColors.Info;
            this.moreInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreInfoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.moreInfoButton.Location = new System.Drawing.Point(1364, 225);
            this.moreInfoButton.Name = "moreInfoButton";
            this.moreInfoButton.Size = new System.Drawing.Size(236, 143);
            this.moreInfoButton.TabIndex = 6;
            this.moreInfoButton.Text = "Character History";
            this.moreInfoButton.UseVisualStyleBackColor = false;
            this.moreInfoButton.Click += new System.EventHandler(this.moreInfoButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.Info;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(1364, 48);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(172, 76);
            this.homeButton.TabIndex = 7;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // historyTextBox
            // 
            this.historyTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.historyTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyTextBox.Location = new System.Drawing.Point(355, 237);
            this.historyTextBox.Multiline = true;
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyTextBox.Size = new System.Drawing.Size(843, 704);
            this.historyTextBox.TabIndex = 8;
            this.historyTextBox.TextChanged += new System.EventHandler(this.historyTextBox_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(2380, 1112);
            this.Controls.Add(this.historyTextBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.moreInfoButton);
            this.Controls.Add(this.kingdomLabels);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label kingdomLabels;
        private System.Windows.Forms.Button moreInfoButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox historyTextBox;
    }
}