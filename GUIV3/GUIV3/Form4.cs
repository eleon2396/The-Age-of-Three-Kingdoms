using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIV3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(600, 600);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            this.Hide();
            home.ShowDialog();
            this.Close();
         
        }

     
    }
}
