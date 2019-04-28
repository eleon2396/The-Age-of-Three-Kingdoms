using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeKingdomsTake2;
using System.IO;
// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace GUIV3
{
    //THIS IS FORM 2 BUT IS ACTUALLY FORM 1 SINCE WE CALL THE FORM1_LOAD
    public partial class Form1 : Form
    {
        private DataTier data;
        private List<Card> hand;
        private List<Card> inFieldCards;
        private List<Card> opponentInfieldCards;
        private ImageList player_hand;
        private ImageList player_field_cards;
        private ImageList opponent_field_cards;
        private int counter;
        private string selectedPowerup;
       
        // create delimiters
        char[] delimiters = { '_', '.' };

        private string kingdomSelected;
        public Form1(String kingdom)
        {
            InitializeComponent();
            this.player_hand = new ImageList();
            this.player_field_cards = new ImageList();
            this.opponent_field_cards = new ImageList();
            this.data = null;
            this.counter = 1;
            this.inFieldCards = new List<Card>();
            this.opponentInfieldCards = new List<Card>();
            this.kingdomSelected = kingdom;
            selectedPowerup = " ";
        }

        // make sure user can't click on buttons when this is called or can click stuff
        //function to set elements enabled or not based on parameter passed
        private void setElementsToBool(bool check)
        {
            connectButton.Enabled = check;
            endTurnButton.Enabled = check;
            playersCardInFieldListView.Enabled = check;
            playersHandListView.Enabled = check;
            opponentsCardsInFieldListView.Enabled = check;
            //combatInfoListView.Enabled = check;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1350, 650);
            playersKingdomDisplayTextBox.Text = kingdomSelected;
            //setElementsToBool(false);
            connectButton.Enabled = true;

        }

        private async void connectButton_ClickAsync(object sender, EventArgs e)
        {
            // escape null socket values
            if (this.data != null)
            {
                //MessageBox.Show("I have been born");
                return;
            }

            this.data = new DataTier(this.kingdomSelected,Convert.ToInt32(this.playerScoreTextBox.Text)); // create a tier to collect incomming information
            await this.data.ConnectToServer(); // Find a server to connect 
            this.hand = this.data.ConvertToCards(await this.data.GetServerData()); // get the incoming data an convert them into a set of cards

            playersHandListView.ShowItemToolTips = true;
            this.player_hand.ImageSize = new Size(112, 112); // Setting all image correctly 
            foreach (Card card in this.hand)
            {
                this.player_hand.Images.Add(card.GetName(), card.getImage());
                string infoo = "Attack: " + card.GetAttack() + " Defense: " + card.GetDefense() + " Type: " + card.GetType();
                this.playersHandListView.Items.Add(card.GetName(), this.player_hand.Images.IndexOfKey(card.GetName())).ToolTipText = infoo; ;
                
            }
            this.playersHandListView.LargeImageList = this.player_hand;

            if (data.CheckIfFirstPlayer() == 0) // if its not your turn, then disable input
            {
                this.setElementsToBool(false);
                this.waitForInput();

            }

        }

        private async void waitForInput()
        {
           
            string info = await data.GetServerData();

            while (data.getProtocol(info) != 4)
            {

                if (data.getProtocol(info) == 3)
                {

                    List<Card> cards = data.ConvertToCards(info);
                    this.opponent_field_cards.ImageSize = new Size(100, 100);
                    opponentsCardsInFieldListView.ShowItemToolTips = true;
                    for (int i = 0; i < cards.Count; i++) // Find the image in the Card List
                    {
                        this.opponent_field_cards.Images.Add(cards[i].GetName(), cards[i].getImage()); // adding the card to the opponent field 
                        this.opponentsCardsInFieldListView.LargeImageList = this.opponent_field_cards;
                        var ViewItem = this.opponentsCardsInFieldListView.Items.Add(cards[i].GetName()); // Return the ViewItem
                        string info2 = "Attack: " + cards[i].GetAttack() + " Defense: " + cards[i].GetDefense() + " Type: " + cards[i].GetType();  ///Displaying info
                        ViewItem.ToolTipText = info2;
                        ViewItem.ImageKey = cards[i].GetName(); // Add the correct image key related to the picture
                        opponentInfieldCards.Add(cards[i]);
                    }
                }
                else if(data.getProtocol(info) == 1)
                {
                    List<Card> cards = data.ConvertToCards(info);
                    this.hand.Add(cards[0]);
                    for (int i = 0; i < cards.Count; i++) // Find the image in the Card List
                    {
                        this.player_hand.Images.Add(cards[i].GetName(), cards[i].getImage()); // adding the card to the opponent field 
                        this.playersHandListView.LargeImageList = this.player_hand;
                        var ViewItem = this.playersHandListView.Items.Add(cards[i].GetName()); // Return the ViewItem
                        ViewItem.ImageKey = cards[i].GetName(); // Add the correct image key related to the picture
                    }
                }
                else if(data.getProtocol(info) == 2)
                {
                    int playerHealth = data.getUpdatedPlayerHealth(info);
                    int EnemyHealth = data.getUpdatedEnemyHealth(info);
                    this.playerScoreTextBox.Text = playerHealth.ToString();
                    this.opponentsScoreTextView.Text = EnemyHealth.ToString();
                }
                else if(data.getProtocol(info) == 5)
                {
                    // tell the player has lost
                    MessageBox.Show(data.GetPlayerName() + " LOST!");
                }

                else if(data.getProtocol(info) == 7)
                {
                    //
                    Console.WriteLine("IM IN PROTOCOL 7");

                    updateCard(info);

                }

                info = await data.GetServerData();

            }
            this.setElementsToBool(true);
        }


        private void endTurnButton_Click(object sender, EventArgs e)
        {
            this.setElementsToBool(false);
            List<Card> dummyCards = new List<Card>();
            dummyCards.Add(new Card("Dummy", "Dummy", -1, -1, -1, Directory.GetCurrentDirectory() + "//Warriors//dummy.jpg"));
            data.SendActionToServer(4, dummyCards);
            this.waitForInput();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string message = "1. Each player is dealt cards which they can hover over with their mouse and it displays statistics. Attack, Defense, Type."
                + Environment.NewLine + Environment.NewLine + "2. Each player can put card(s) onto their field and attack the opponent." +
                Environment.NewLine + "There exist 5 Cards: Hero, Assassin, Trap, Weapon, Horse." + Environment.NewLine +
                "       Hero: Attacks the players lifepoints" + Environment.NewLine + "       Assassin: Kills an enemy Hero." + Environment.NewLine +
                "       Trap: Steals an enemy's Hero." + Environment.NewLine + "        Weapon: Boosts hero's attack points" +
                Environment.NewLine + "       Horse: Boost's a hero's defense points" + Environment.NewLine + Environment.NewLine +
                "3. To power up a hero first click the hero card then click the weapon/horse card" + Environment.NewLine + Environment.NewLine +
                "4. Player may only attack once with a hero card per turn";
            string title = "Game Rules";
            MessageBox.Show(message, title);
        }

        private void opponentsCardsInFieldListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateCard(String info)
        {
            List<Card> newCards = new List<Card>();

            newCards = data.ConvertToCards(info);

            for (int i = 0; i < opponentInfieldCards.Count; i++)
            {
                if (opponentInfieldCards[i].GetName() == newCards[1].GetName())
                {
                    Console.WriteLine("IN THE IF STATEMENT");
                   
                    this.opponentsCardsInFieldListView.Items.RemoveAt(i);
                    opponentInfieldCards.RemoveAt(i);
                }

            }
            //Console.WriteLine("SAZON: " + opponentInfieldCards[found].GetName() + " " + selectedPowerup);


        }

        private async void playersCardInFieldListView_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (this.playersCardInFieldListView.SelectedItems.Count == 0) // this code works plz don't touch it, our make-shift try catch
            {
                return;
            }
            List<Card> powerUp = new List<Card>();
            string imageSelected = new String(this.playersCardInFieldListView.SelectedItems[0].Text.ToCharArray()); // select the card

            //Weapon , check and set specific variable for attack cards
            if (imageSelected.Contains("Sword") || imageSelected.Contains("Bow") || imageSelected.Contains("Horse"))
            {
                selectedPowerup = imageSelected;
                // MessageBox.Show(selectedPowerupWeapon);

            }

           /* else if (imageSelected.Contains("Trap"))
            {
                selectedPowerup = imageSelected;

          
                for(int i = 0; i < inFieldCards.Count; i++)
                {
                    if(inFieldCards[i].GetName() == selectedPowerup)
                    {
                        powerUp.Add(inFieldCards[i]);
                            
                       
                    }
                }

                for(int i = 0; i < opponentInfieldCards.Count; i++)
                {
                    powerUp.Add(opponentInfieldCards[i]);
                }

                data.SendActionToServer(8, powerUp);
                String info = await data.GetServerData();
                //info = await data.GetServerData();

                List<Card> newCards = new List<Card>();

                Console.WriteLine("THIS IS IN THE TRAP: " + info);

                if (data.getProtocol(info) == 8)
                {
                    newCards = data.ConvertToCards(info);

                    for(int i = 0; i < newCards.Count; i++)
                    {
                        Console.WriteLine("PLES: " + newCards[i].GetName() + " " + newCards[i].getImagePath());
                    }


                   /* for (int i = 0; i < inFieldCards.Count; i++)
                    {
                        if (inFieldCards[i].GetName() == selectedPowerup)
                        {
                            this.playersCardInFieldListView.Items.RemoveAt(i);
                            inFieldCards.RemoveAt(i);
                            Image stolenHeroImg = Image.FromFile(newCards[1].getImagePath());
                            // playersCardInFieldListView.Items.Add()
                            

                            this.player_field_cards.Images.Add(newCards[1].GetName(), newCards[1].getImage());
                            inFieldCards.Add(newCards[1]);


                            
                            Console.WriteLine("STOLEN HERO: " + newCards[1].GetName());
                        }

                        //Console.WriteLine(inFieldCards[i].GetName());
                    }

                }*/

               /* else
                {
                    //MessageBox.Show("THATS NEGATIVE. 2");
                    info = await data.GetServerData();

                    newCards = data.ConvertToCards(info);

                    for (int i = 0; i < newCards.Count; i++)
                    {
                        Console.WriteLine("PLES2: " + newCards[i].GetName() + " " + newCards[i].getImagePath());
                    }


                   /* for (int i = 0; i < inFieldCards.Count; i++)
                    {
                        if (inFieldCards[i].GetName() == selectedPowerup)
                        {
                            this.playersCardInFieldListView.Items.RemoveAt(i);
                            inFieldCards.RemoveAt(i);

                            Image stolenHeroImg = Image.FromFile(newCards[1].getImagePath());
                            // playersCardInFieldListView.Items.Add()
                            
                            this.player_field_cards.Images.Add(newCards[1].GetName(), newCards[1].getImage());
                            inFieldCards.Add(newCards[1]);

                            Console.WriteLine("STOLEN HERO: " + newCards[1].GetName());
                        }

                        //Console.WriteLine(inFieldCards[i].GetName());
                    }
                }
            }*/

      
            else if(selectedPowerup != " ") 
                {

                    //Get the hero card and add it
                    for (int i = 0; i < inFieldCards.Count; i++)
                    {
                        if (inFieldCards[i].GetName() == imageSelected)
                        {
                            // MessageBox.Show(imageSelected);
                            powerUp.Add(inFieldCards[i]);

                        }

                    }

                    //Get the weapon card and add it
                    for (int i = 0; i < inFieldCards.Count; i++)
                    {
                        if (inFieldCards[i].GetName() == selectedPowerup)
                        {
                            // MessageBox.Show(selectedPowerupWeapon);
                            powerUp.Add(inFieldCards[i]);

                        }

                    }

                    data.SendActionToServer(7, powerUp);

                    String info = await data.GetServerData();
                    List<Card> newCards = new List<Card>();

                    //  MessageBox.Show(info);

                    if (data.getProtocol(info) == 7)
                    {
                        newCards = data.ConvertToCards(info);
                        // Console.WriteLine(newCards[0].GetName());
                        //MessageBox.Show("This Works");

                        for (int i = 0; i < inFieldCards.Count; i++)
                        {
                            if (inFieldCards[i].GetName() == selectedPowerup)
                            {
                                this.playersCardInFieldListView.Items.RemoveAt(i);
                                inFieldCards.RemoveAt(i);

                            }

                            //Console.WriteLine(inFieldCards[i].GetName());
                        }
                    }
                    else
                    {
                        MessageBox.Show("THATS NEGATIVE. 1");
                    }
                
            }
        }

        private void powerupHero(String powerUp, String hero)
        {

        }

        private void playersHandListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Card> playedCards = new List<Card>();
            if(this.playersHandListView.SelectedItems.Count == 0) // this code works plz don't touch it, our make-shift try catch
            {
                return;
            }
            string imageSelected = new String(this.playersHandListView.SelectedItems[0].Text.ToCharArray()); // select the card

            // Turn into array
            //String[] powerUp = imageSelected.Split(delimiters);

            // MessageBox.Show("hello");
           //  MessageBox.Show(imageSelected);
            this.playersHandListView.SelectedItems[0].Remove(); // delete the image
            Card infoOfCharacter = this.hand[0];
            this.player_field_cards.ImageSize = new Size(100, 100);
            this.playersCardInFieldListView.ShowItemToolTips = true;
            for (int i = 0; i < this.hand.Count; i++) // Find the image in the Card List
            {
                if(this.hand[i].GetName() == imageSelected) // Image is FOUND!
                {
                    this.player_field_cards.Images.Add(imageSelected, this.hand[i].getImage()); // adding the card to the players field 
                    playedCards.Add(hand[i]); //add image to new played card list to display on opponent list view
                    this.inFieldCards.Add(hand[i]);
                    infoOfCharacter = hand[i];
                    this.hand.RemoveAt(i); // remove player card from hand List

                    break;
                }
            }
            this.playersCardInFieldListView.LargeImageList = this.player_field_cards;
            var ViewItem = this.playersCardInFieldListView.Items.Add(imageSelected); // Return the ViewItem
            string info = "Attack: " + infoOfCharacter.GetAttack() + " Defense: " + infoOfCharacter.GetDefense() + " Type: " + infoOfCharacter.GetType();  ///Displaying info
            ViewItem.ToolTipText = info;
            ViewItem.ImageKey = imageSelected; // Add the correct image key related to the picture

            //Once image is selected, send code to the opponents imagelist
            data.SendActionToServer(3, playedCards);



        }

       /* private void kingdomSelectionCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gets the string and makes the elements invisible so that the user cannot select a new kingdom
            //Text box 2 is used for testing
           // string kingdomSelected = kingdomSelectionCheckListBox.SelectedItem.ToString();
          // setCheckedListBox(false);
            
                
            
            
        }*/

        private void combatInfoListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playersKingdomDisplayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kingdomSelectedLabel_Click(object sender, EventArgs e)
        {

        }

        // need to disable button too
        private async void AttackPlayeraButton_Click(object sender, EventArgs e)
        {
            String itemSelected = playersCardInFieldListView.SelectedItems[0].Text.ToString();
            if(itemSelected != null)
            {
                foreach(Card c in this.inFieldCards)
                {
                    if(c.GetName() == itemSelected)
                    {
                        List<Card> temp = new List<Card>();
                        temp.Add(c);
                        data.SendActionToServer(2, temp);
                        String rawData = await data.GetServerData();
                        int playerHealth = data.getUpdatedPlayerHealth(rawData);
                        int EnemyHealth = data.getUpdatedEnemyHealth(rawData);
                        if(EnemyHealth <= 0)
                        {
                            MessageBox.Show(data.GetPlayerName() + " WON!");
                        }
                        this.playerScoreTextBox.Text = playerHealth.ToString();
                        this.opponentsScoreTextView.Text = EnemyHealth.ToString();
                    }
                }
            }
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
