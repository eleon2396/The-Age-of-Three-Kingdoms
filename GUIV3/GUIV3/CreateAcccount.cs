using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;

namespace GUIV3
{
    public partial class CreateAcccount : Form
    {
        private QueryBuilder builder;
        public CreateAcccount()
        {
            builder = new QueryBuilder();
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Form6 login = new Form6();
            this.Hide();
            login.ShowDialog();
            this.Close();

            /*if (this.FirstNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter First name");
                return;
            }
            if (this.LastNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Last name");
                return;
            }
            if (this.emailTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Email");
                return;
            }
            if (this.passwordTextBox1.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                return;
            }
            if (this.usernameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Username");
                return;
            }
            try
            {
                Boolean isVaild = this.builder.buildAccountQuery(this.FirstNameTextBox.Text, this.LastNameTextBox.Text, this.emailTextBox.Text, this.emailTextBox.Text, this.usernameTextBox.Text);
                if (isVaild)
                {
                    MessageBox.Show("Account has been created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAcccount_Load(object sender, EventArgs e)
        {

        }
    }
}
