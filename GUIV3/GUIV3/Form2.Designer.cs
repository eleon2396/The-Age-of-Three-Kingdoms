namespace GUIV3
{
    partial class Form2
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
            this.startGameFormButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.selectingKingdomLabel = new System.Windows.Forms.Label();
            this.kingdomSelectionCheckListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startGameFormButton
            // 
            this.startGameFormButton.BackColor = System.Drawing.SystemColors.Info;
            this.startGameFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameFormButton.Location = new System.Drawing.Point(1425, 256);
            this.startGameFormButton.Name = "startGameFormButton";
            this.startGameFormButton.Size = new System.Drawing.Size(201, 109);
            this.startGameFormButton.TabIndex = 0;
            this.startGameFormButton.Text = "Start";
            this.startGameFormButton.UseVisualStyleBackColor = false;
            this.startGameFormButton.Click += new System.EventHandler(this.startGameFormButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.Info;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(341, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1121, 79);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "THE AGE OF THREE KINGDOMS";
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.SystemColors.Info;
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.Location = new System.Drawing.Point(1761, 256);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(201, 109);
            this.statisticsButton.TabIndex = 3;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.SystemColors.Info;
            this.HistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.Location = new System.Drawing.Point(2072, 256);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(201, 109);
            this.HistoryButton.TabIndex = 4;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.titlePictureBox.Image = global::GUIV3.Properties.Resources.titleScreen1;
            this.titlePictureBox.InitialImage = null;
            this.titlePictureBox.Location = new System.Drawing.Point(85, 115);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(1150, 912);
            this.titlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlePictureBox.TabIndex = 5;
            this.titlePictureBox.TabStop = false;
            this.titlePictureBox.Click += new System.EventHandler(this.titlePictureBox_Click);
            // 
            // selectingKingdomLabel
            // 
            this.selectingKingdomLabel.AutoSize = true;
            this.selectingKingdomLabel.BackColor = System.Drawing.SystemColors.Info;
            this.selectingKingdomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectingKingdomLabel.Location = new System.Drawing.Point(1306, 497);
            this.selectingKingdomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectingKingdomLabel.Name = "selectingKingdomLabel";
            this.selectingKingdomLabel.Size = new System.Drawing.Size(967, 37);
            this.selectingKingdomLabel.TabIndex = 23;
            this.selectingKingdomLabel.Text = "Please Select one of the following Kingdoms then press \'Start\':";
            // 
            // kingdomSelectionCheckListBox
            // 
            this.kingdomSelectionCheckListBox.BackColor = System.Drawing.SystemColors.Info;
            this.kingdomSelectionCheckListBox.CheckOnClick = true;
            this.kingdomSelectionCheckListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kingdomSelectionCheckListBox.FormattingEnabled = true;
            this.kingdomSelectionCheckListBox.Location = new System.Drawing.Point(1313, 641);
            this.kingdomSelectionCheckListBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.kingdomSelectionCheckListBox.Name = "kingdomSelectionCheckListBox";
            this.kingdomSelectionCheckListBox.Size = new System.Drawing.Size(468, 136);
            this.kingdomSelectionCheckListBox.TabIndex = 24;
            this.kingdomSelectionCheckListBox.SelectedIndexChanged += new System.EventHandler(this.kingdomSelectionCheckListBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(2516, 1075);
            this.Controls.Add(this.kingdomSelectionCheckListBox);
            this.Controls.Add(this.selectingKingdomLabel);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startGameFormButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGameFormButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.PictureBox titlePictureBox;
        private System.Windows.Forms.Label selectingKingdomLabel;
        private System.Windows.Forms.CheckedListBox kingdomSelectionCheckListBox;
    }
}