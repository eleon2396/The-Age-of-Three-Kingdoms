using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeKingdomsTake2;
using System.IO;

namespace GUIV3
{
    class DataTier
    {

        private Player player;
        private static String DIR = Directory.GetCurrentDirectory();
        private int isFirstPlayer;

        public DataTier(String name,int lp)
        {
            this.player = new Player(name, lp);
        }

        public DataTier(Player player)
        {
            this.player = player;
        }

        public String GetPlayerName()
        {
            return player.GetName();
        }

        // indicate that the client socket should connect to the server
        public async Task ConnectToServer()
        {
            await player.ConnectToServer();
        }

        // get the protocol information from the raw data provided
        public int getProtocol(String rawData)
        {

            Console.WriteLine("FROM PROTOCOL: " + rawData);

            String protocol = "" + rawData[0];
            return Int32.Parse(protocol);
        }

        // unpack the data recieved from the server to see what infomration was recieved.
        private String UnpackBytes(Byte[] payload)
        {
            return Encoding.ASCII.GetString(payload);
        }

        // get information that will give the protocol as well as the data to update.
        public async Task<String> GetServerData()
        {
            byte[] info = await player.RecServerData();
            return UnpackBytes(info);
        }

        // convert the raw data provided into a list of card instances
        public List<Card> ConvertToCards(String rawData)
        {
            // strip the protocol from the data
            String allCardInfo = rawData.Substring(2);
            String[] singleCardInfo = allCardInfo.Split('-');

            // create an empty list to store the cards
            List<Card> playerHand = new List<Card>();
            foreach(String s in singleCardInfo)
            {
                String[] cardData = s.Split(' ');
                if (cardData.Length > 2)
                {
                    // string imagePath = DIR + "//Warriors//" + cardData[0] + ".jpg";
                    Card card = new Card(cardData[0], "", Int32.Parse(cardData[1]), Int32.Parse(cardData[2]), 0, GetImagePath(cardData[0]));
                    playerHand.Add(card);
                }
            }

            Console.WriteLine(allCardInfo);

            return playerHand; 
        }

        // get image path based on the names of the cards
        public String GetImagePath(String cardName)
        {
            String imagePath = DIR + "//Warriors";
            // create delimiters
            char[] delimiters = { '_', '.' };

            // instance that will hold information on all files in a directory
            DirectoryInfo info = new DirectoryInfo(DIR + "//Warriors");

            // get all files with the .jpg extension
            FileInfo[] Files = info.GetFiles("*.jpg");

            // loop through each file
            foreach (FileInfo file in Files)
            {
                // get the name of the file
                String imageFileName = file.Name;
                String[] imgName = imageFileName.Split(delimiters);

                // check if the name of the file is the same as the passed in parameter variable
                if (string.Compare(imgName[1], cardName) == 0)
                    imagePath += "//" + file;

            }

            return imagePath;
        }

        // will combine both the protocol intented to be done and the card list passed through
        public void SendActionToServer(int protocol, List<Card> affectedCards)
        {
            String dataToBeConverted = protocol.ToString() + " ";

            foreach(Card c in affectedCards)
                dataToBeConverted += c.GetName() + " " + c.GetAttack().ToString() + " " + c.GetDefense().ToString() + "-";

            Console.WriteLine(dataToBeConverted);
            player.SendToServer(dataToBeConverted);
            Console.WriteLine("Data sent to server!");
        }

        // check if this client is the first player, this will determine who goes first and which turns theyre allowed to act on.
        public int CheckIfFirstPlayer()
        {
            return player.CheckIsFirstPlayer();
        }

        // get the user's health stats
        public int getUpdatedPlayerHealth(String healthStats)
        {
            String[] parsedHealth = healthStats.Split(' ');
            int thisPlayerHealth;

            // check if the client of this program is marked as player 1
            if(player.CheckIsFirstPlayer() == 1)
            {
                thisPlayerHealth = Int32.Parse(parsedHealth[1]);
            }
            else if(player.CheckIsFirstPlayer() == 0)
            {
                thisPlayerHealth = Int32.Parse(parsedHealth[2]);
            }
            else
            {
                // THIS SHOULD NEVER HAPPEN (i hope)
                thisPlayerHealth = 1000;
            }

            return thisPlayerHealth;
        }


        // get the enemy's health stats
        public int getUpdatedEnemyHealth(String healthStats)
        {
            String[] parsedHealth = healthStats.Split(' ');
            int EnemyHealth;

            // check if the client of this program is marked as player 1
            if (player.CheckIsFirstPlayer() == 1)
            {
                EnemyHealth = Int32.Parse(parsedHealth[2]);
            }
            else if (player.CheckIsFirstPlayer() == 0)
            {
                EnemyHealth = Int32.Parse(parsedHealth[1]);
            }
            else
            {
                // THIS SHOULD NEVER HAPPEN (i hope)
                EnemyHealth = 1000;
            }

            return EnemyHealth;
        }
    }
}
