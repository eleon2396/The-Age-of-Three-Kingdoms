namespace GUIV3
{
    partial class CreateAcccount
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
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "username";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(404, 33);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(148, 31);
            this.usernameTextBox.TabIndex = 20;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(404, 381);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(112, 36);
            this.CreateButton.TabIndex = 19;
            this.CreateButton.Text = "Sign Up";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(404, 292);
            this.passwordTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '*';
            this.passwordTextBox1.Size = new System.Drawing.Size(148, 31);
            this.passwordTextBox1.TabIndex = 18;
            this.passwordTextBox1.TextChanged += new System.EventHandler(this.passwordTextBox1_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(404, 226);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(148, 31);
            this.emailTextBox.TabIndex = 17;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(404, 156);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(148, 31);
            this.LastNameTextBox.TabIndex = 16;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(404, 97);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(148, 31);
            this.FirstNameTextBox.TabIndex = 15;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "LastName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "FirstName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateAcccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAcccount";
            this.Text = "CreateAcccount";
            this.Load += new System.EventHandler(this.CreateAcccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}