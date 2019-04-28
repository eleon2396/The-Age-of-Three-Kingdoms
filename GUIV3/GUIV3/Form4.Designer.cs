namespace GUIV3
{
    partial class Form4
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
            this.homeButton = new System.Windows.Forms.Button();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.Info;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(901, 81);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(124, 60);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AutoSize = true;
            this.statisticsLabel.BackColor = System.Drawing.SystemColors.Info;
            this.statisticsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsLabel.Location = new System.Drawing.Point(55, 68);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(299, 73);
            this.statisticsLabel.TabIndex = 1;
            this.statisticsLabel.Text = "Statistics";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 1018);
            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.homeButton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label statisticsLabel;
    }
}