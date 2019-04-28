namespace GUIV3
{
    partial class Form1
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.playersHandListView = new System.Windows.Forms.ListView();
            this.playersCardInFieldListView = new System.Windows.Forms.ListView();
            this.opponentsCardsInFieldListView = new System.Windows.Forms.ListView();
            this.playersCardsinFieldTextBox = new System.Windows.Forms.TextBox();
            this.opponentsCardsInFieldTextBox = new System.Windows.Forms.TextBox();
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.opponentsScoreTextView = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.opponentScoreLabel = new System.Windows.Forms.Label();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.playersHandLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.kingdomSelectedLabel = new System.Windows.Forms.Label();
            this.playersKingdomDisplayTextBox = new System.Windows.Forms.TextBox();
            this.AttackPlayeraButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(34, 40);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(1224, 74);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "THE AGE OF THREE KINGDOMS";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.Info;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(34, 175);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(160, 77);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_ClickAsync);
            // 
            // playersHandListView
            // 
            this.playersHandListView.BackColor = System.Drawing.SystemColors.Info;
            this.playersHandListView.Location = new System.Drawing.Point(34, 256);
            this.playersHandListView.Margin = new System.Windows.Forms.Padding(4);
            this.playersHandListView.Name = "playersHandListView";
            this.playersHandListView.Size = new System.Drawing.Size(328, 610);
            this.playersHandListView.TabIndex = 3;
            this.playersHandListView.UseCompatibleStateImageBehavior = false;
            this.playersHandListView.SelectedIndexChanged += new System.EventHandler(this.playersHandListView_SelectedIndexChanged);
            // 
            // playersCardInFieldListView
            // 
            this.playersCardInFieldListView.BackColor = System.Drawing.SystemColors.Info;
            this.playersCardInFieldListView.Location = new System.Drawing.Point(1336, 762);
            this.playersCardInFieldListView.Margin = new System.Windows.Forms.Padding(4);
            this.playersCardInFieldListView.Name = "playersCardInFieldListView";
            this.playersCardInFieldListView.Size = new System.Drawing.Size(1288, 221);
            this.playersCardInFieldListView.TabIndex = 4;
            this.playersCardInFieldListView.UseCompatibleStateImageBehavior = false;
            this.playersCardInFieldListView.SelectedIndexChanged += new System.EventHandler(this.playersCardInFieldListView_SelectedIndexChanged);
            // 
            // opponentsCardsInFieldListView
            // 
            this.opponentsCardsInFieldListView.BackColor = System.Drawing.SystemColors.Info;
            this.opponentsCardsInFieldListView.Location = new System.Drawing.Point(1336, 423);
            this.opponentsCardsInFieldListView.Margin = new System.Windows.Forms.Padding(4);
            this.opponentsCardsInFieldListView.Name = "opponentsCardsInFieldListView";
            this.opponentsCardsInFieldListView.Size = new System.Drawing.Size(1288, 221);
            this.opponentsCardsInFieldListView.TabIndex = 5;
            this.opponentsCardsInFieldListView.UseCompatibleStateImageBehavior = false;
            this.opponentsCardsInFieldListView.SelectedIndexChanged += new System.EventHandler(this.opponentsCardsInFieldListView_SelectedIndexChanged);
            // 
            // playersCardsinFieldTextBox
            // 
            this.playersCardsinFieldTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.playersCardsinFieldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersCardsinFieldTextBox.Location = new System.Drawing.Point(1336, 712);
            this.playersCardsinFieldTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.playersCardsinFieldTextBox.Name = "playersCardsinFieldTextBox";
            this.playersCardsinFieldTextBox.ReadOnly = true;
            this.playersCardsinFieldTextBox.Size = new System.Drawing.Size(392, 44);
            this.playersCardsinFieldTextBox.TabIndex = 6;
            this.playersCardsinFieldTextBox.Text = "Player\'s Cards in Field";
            // 
            // opponentsCardsInFieldTextBox
            // 
            this.opponentsCardsInFieldTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.opponentsCardsInFieldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentsCardsInFieldTextBox.Location = new System.Drawing.Point(1336, 363);
            this.opponentsCardsInFieldTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.opponentsCardsInFieldTextBox.Name = "opponentsCardsInFieldTextBox";
            this.opponentsCardsInFieldTextBox.ReadOnly = true;
            this.opponentsCardsInFieldTextBox.Size = new System.Drawing.Size(392, 44);
            this.opponentsCardsInFieldTextBox.TabIndex = 7;
            this.opponentsCardsInFieldTextBox.Text = "Opponent\'s Cards in Field";
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.playerScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreTextBox.Location = new System.Drawing.Point(1796, 112);
            this.playerScoreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.ReadOnly = true;
            this.playerScoreTextBox.Size = new System.Drawing.Size(158, 44);
            this.playerScoreTextBox.TabIndex = 9;
            this.playerScoreTextBox.Text = "1000";
            // 
            // opponentsScoreTextView
            // 
            this.opponentsScoreTextView.BackColor = System.Drawing.SystemColors.Info;
            this.opponentsScoreTextView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentsScoreTextView.Location = new System.Drawing.Point(1796, 194);
            this.opponentsScoreTextView.Margin = new System.Windows.Forms.Padding(4);
            this.opponentsScoreTextView.Name = "opponentsScoreTextView";
            this.opponentsScoreTextView.ReadOnly = true;
            this.opponentsScoreTextView.Size = new System.Drawing.Size(158, 44);
            this.opponentsScoreTextView.TabIndex = 10;
            this.opponentsScoreTextView.Text = "1000";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.Info;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(1472, 52);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(109, 37);
            this.scoreLabel.TabIndex = 11;
            this.scoreLabel.Text = "Score:";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.BackColor = System.Drawing.SystemColors.Info;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.Location = new System.Drawing.Point(1472, 119);
            this.playerScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(115, 37);
            this.playerScoreLabel.TabIndex = 12;
            this.playerScoreLabel.Text = "Player:";
            // 
            // opponentScoreLabel
            // 
            this.opponentScoreLabel.AutoSize = true;
            this.opponentScoreLabel.BackColor = System.Drawing.SystemColors.Info;
            this.opponentScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentScoreLabel.Location = new System.Drawing.Point(1472, 194);
            this.opponentScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opponentScoreLabel.Name = "opponentScoreLabel";
            this.opponentScoreLabel.Size = new System.Drawing.Size(167, 37);
            this.opponentScoreLabel.TabIndex = 13;
            this.opponentScoreLabel.Text = "Opponent:";
            // 
            // endTurnButton
            // 
            this.endTurnButton.BackColor = System.Drawing.SystemColors.Info;
            this.endTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTurnButton.Location = new System.Drawing.Point(200, 175);
            this.endTurnButton.Margin = new System.Windows.Forms.Padding(4);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(162, 77);
            this.endTurnButton.TabIndex = 14;
            this.endTurnButton.Text = "End Turn";
            this.endTurnButton.UseVisualStyleBackColor = false;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // playersHandLabel
            // 
            this.playersHandLabel.AutoSize = true;
            this.playersHandLabel.BackColor = System.Drawing.SystemColors.Info;
            this.playersHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersHandLabel.Location = new System.Drawing.Point(68, 869);
            this.playersHandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playersHandLabel.Name = "playersHandLabel";
            this.playersHandLabel.Size = new System.Drawing.Size(215, 37);
            this.playersHandLabel.TabIndex = 15;
            this.playersHandLabel.Text = "Player\'s Hand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.Info;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(2500, 40);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(124, 60);
            this.helpButton.TabIndex = 19;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // kingdomSelectedLabel
            // 
            this.kingdomSelectedLabel.AutoSize = true;
            this.kingdomSelectedLabel.BackColor = System.Drawing.SystemColors.Info;
            this.kingdomSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kingdomSelectedLabel.Location = new System.Drawing.Point(34, 981);
            this.kingdomSelectedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kingdomSelectedLabel.Name = "kingdomSelectedLabel";
            this.kingdomSelectedLabel.Size = new System.Drawing.Size(301, 37);
            this.kingdomSelectedLabel.TabIndex = 24;
            this.kingdomSelectedLabel.Text = "Kingdom Selected:";
            this.kingdomSelectedLabel.Click += new System.EventHandler(this.kingdomSelectedLabel_Click);
            // 
            // playersKingdomDisplayTextBox
            // 
            this.playersKingdomDisplayTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.playersKingdomDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersKingdomDisplayTextBox.Location = new System.Drawing.Point(386, 971);
            this.playersKingdomDisplayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.playersKingdomDisplayTextBox.Name = "playersKingdomDisplayTextBox";
            this.playersKingdomDisplayTextBox.ReadOnly = true;
            this.playersKingdomDisplayTextBox.Size = new System.Drawing.Size(422, 44);
            this.playersKingdomDisplayTextBox.TabIndex = 25;
            this.playersKingdomDisplayTextBox.TextChanged += new System.EventHandler(this.playersKingdomDisplayTextBox_TextChanged);
            // 
            // AttackPlayeraButton
            // 
            this.AttackPlayeraButton.BackColor = System.Drawing.SystemColors.Info;
            this.AttackPlayeraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackPlayeraButton.Location = new System.Drawing.Point(946, 846);
            this.AttackPlayeraButton.Margin = new System.Windows.Forms.Padding(6);
            this.AttackPlayeraButton.Name = "AttackPlayeraButton";
            this.AttackPlayeraButton.Size = new System.Drawing.Size(380, 140);
            this.AttackPlayeraButton.TabIndex = 26;
            this.AttackPlayeraButton.Text = "Attack Player";
            this.AttackPlayeraButton.UseVisualStyleBackColor = false;
            this.AttackPlayeraButton.Click += new System.EventHandler(this.AttackPlayeraButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.Info;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(2500, 119);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(124, 60);
            this.homeButton.TabIndex = 27;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(2694, 1056);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.AttackPlayeraButton);
            this.Controls.Add(this.playersKingdomDisplayTextBox);
            this.Controls.Add(this.kingdomSelectedLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playersHandLabel);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.opponentScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.opponentsScoreTextView);
            this.Controls.Add(this.playerScoreTextBox);
            this.Controls.Add(this.opponentsCardsInFieldTextBox);
            this.Controls.Add(this.playersCardsinFieldTextBox);
            this.Controls.Add(this.opponentsCardsInFieldListView);
            this.Controls.Add(this.playersCardInFieldListView);
            this.Controls.Add(this.playersHandListView);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.titleTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListView playersHandListView;
        private System.Windows.Forms.ListView playersCardInFieldListView;
        private System.Windows.Forms.ListView opponentsCardsInFieldListView;
        private System.Windows.Forms.TextBox playersCardsinFieldTextBox;
        private System.Windows.Forms.TextBox opponentsCardsInFieldTextBox;
        private System.Windows.Forms.TextBox playerScoreTextBox;
        private System.Windows.Forms.TextBox opponentsScoreTextView;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label opponentScoreLabel;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.Label playersHandLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label kingdomSelectedLabel;
        private System.Windows.Forms.TextBox playersKingdomDisplayTextBox;
        private System.Windows.Forms.Button AttackPlayeraButton;
        private System.Windows.Forms.Button homeButton;
    }
}

