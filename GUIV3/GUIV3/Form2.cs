using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUIV3
{

    //THIS IS FORM 1 BUT IS ACTUALLY FORM 2 SINCE WE CALL THE FORM1_LOAD

    public partial class Form2 : Form
    {

        private string kingdomSelected;
        public Form2()
        {
            
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1275, 600);
            startGameFormButton.Enabled = false;
            intializeCheckedBoxList();
        }

        private void startGameFormButton_Click(object sender, EventArgs e)
        {

            Form1 start = new Form1(kingdomSelected);
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            Form4 stats = new Form4();
            this.Hide();
            stats.ShowDialog();
            this.Close();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            Form5 history = new Form5();
            this.Hide();
            history.ShowDialog();
            this.Close();
        }

        private void titlePictureBox_Click(object sender, EventArgs e)
        {
          
        }

        //function to initialize the checkedBoxList with the three kingdoms.
        private void intializeCheckedBoxList()
        {
            kingdomSelectionCheckListBox.Items.Add("Wei Kingdom");
            kingdomSelectionCheckListBox.Items.Add("Shu Kingdom");
            kingdomSelectionCheckListBox.Items.Add("Wu Kingdom");

        }

        //function to set the checklistbox once the user selects one option
        //This doesnt let the user be able to select something else
         private void setCheckedListBox(bool check)
         {
             kingdomSelectionCheckListBox.Enabled = check;
             kingdomSelectionCheckListBox.Visible = check;
             selectingKingdomLabel.Enabled = check;
             selectingKingdomLabel.Visible = check;
         }


        private void kingdomSelectionCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gets the string and makes the elements invisible so that the user cannot select a new kingdom
            //Text box 2 is used for testing
            kingdomSelected = kingdomSelectionCheckListBox.SelectedItem.ToString();
            startGameFormButton.Enabled = true;
                // setCheckedListBox(false);
            //playersKingdomDisplayTextBox.Text = kingdomSelected;
           // setElementsToBool(true);

        }
    }
}
