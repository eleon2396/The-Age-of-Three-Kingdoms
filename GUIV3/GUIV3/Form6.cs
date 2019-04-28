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
    public partial class Form6 : Form
    {

        private QueryBuilder builder;
        public Form6()
        {
            this.builder = new QueryBuilder();
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           // CreateAccount form = new CreateAccount();
           // form.ShowDialog();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            CreateAcccount form = new CreateAcccount();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        // For now this will be can until we can get the database to work...
        private void signInButton_Click(object sender, EventArgs e)
        {

            String email = this.emailTextBox.Text;
            String password = this.passwordTextBox.Text;
            
            if(email != "" && password != "")
            {
                Form2 mainMenu = new Form2();
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }


          /*  if (this.emailTextBox.Text == "")
            {
                MessageBox.Show("Please Enter an Email");
                return;
            }
            if (this.passwordTextBox.Text == "")
            {
                MessageBox.Show("Please Enter an Password");
                return;
            }

            Boolean login = this.builder.checkAccountQuery(this.emailTextBox.Text, this.passwordTextBox.Text);
            if (login)
            {
                MessageBox.Show("Account Valid!!!");

                Form6 mainMenu = new Form6();
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();


            }

            else
            {
                MessageBox.Show("Account Invalid!!!");
            }
            */



        }
    }
}
