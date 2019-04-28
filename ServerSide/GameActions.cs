using CardsPackage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace GameServer
{

    class GameActions
    {

        private static String DIR = Directory.GetCurrentDirectory();
        private Updater updater;
        private List<Card> deck;
        private int player1LifePoints;
        private int player2LifePoints;

        //                     0      1        2           3           4          5        6         7       8
        enum PROTOCOL : byte {START, DEAL, ATTACKPLAYER, PLACECARD, ENDTURN, ENDGAME, ATTACKCARD, BUFFCARD, TRAPCARD};
        public GameActions()
        {
            // Create a new instance of Updater. This will update one or both players with specific information.
            updater = new Updater();
            Console.WriteLine(DIR);
            this.player1LifePoints = 1000;
            this.player2LifePoints = 1000;
        }

        // determines who the first player will be and updates both players on the information
        public void ChooseFirstPlayer(Socket player1, Socket player2)
        {
            // init byte arrays to pass to socket
            Byte[] first = new byte[256];
            Byte[] second = new byte[256];

            // fill first bit with data
            first[0] = 0;
            first[1] = 1;
            second[0] = 0;
            second[1] = 0;

            // update both players with appropriate data
            updater.UpdateOnePlayer(player1, first);
            updater.UpdateOnePlayer(player2, second);
        }

        // shuffle the deck of cards and deal them to the players
        public void DealKingdomCards(Socket player1, Socket player2)
        {
            // create 2 empty sets of hands for the players
            List<Card> player1Hand = new List<Card>();
            List<Card> player2Hand = new List<Card>();

            // create a fresh deck of cards
            deck = PopulateDeck();

            // shuffle the deck
            deck = ShuffleDeck(deck);

            // distribute 5 cards each among the two players
            for(int i = 0; i < 5; i++)
            {
                player1Hand.Add(deck[i]);
                deck.RemoveAt(i);
            }
            for (int i = 0; i < 5; i++)
            {
                player2Hand.Add(deck[i]);
                deck.RemoveAt(i);
            }

            // send card respective card information to each player
            int protocol = (int)PROTOCOL.DEAL;

            // send cards to player 1
            String info = protocol.ToString() + " ";
            foreach (Card c in player1Hand)
                info += c.GetName() + " " + c.GetAttack().ToString() + " " + c.GetDefense().ToString() + "-";
            byte[] payload = Encoding.ASCII.GetBytes(info);
            updater.UpdateOnePlayer(player1, payload);

            // send the cards to player 2
            info = protocol.ToString() + " ";
            foreach (Card c in player2Hand)
                info += c.GetName() + " " + c.GetAttack().ToString() + " " + c.GetDefense().ToString() + "-";
            payload = Encoding.ASCII.GetBytes(info);
            updater.UpdateOnePlayer(player2, payload);
        }

        // shuffle the deck to make it a fair games
        private List<Card> ShuffleDeck(List<Card> unshuffledDeck)
        {
            List<Card> cardDeck = new List<Card>();
            Random rnd = new Random();
            int rndNumber = 0;

            while(unshuffledDeck.Count > 0)
            {
                rndNumber = rnd.Next(0, unshuffledDeck.Count);
                cardDeck.Add(unshuffledDeck[rndNumber]);
                unshuffledDeck.RemoveAt(rndNumber);
            }

            return cardDeck;
        }

        // get all the cards from the images folder and creates unique instances for each one while also assigning stats
        private List<Card> PopulateDeck()
        {
            // create the list of cards that will be returned
            List<Card> freshDeck = new List<Card>();

            // create random instance to decide on values of cards
            Random rnd = new Random();

            // create delimiters
            char[] delimiters = {'_', '.'};

            // instance that will hold information on all files in a directory
            DirectoryInfo info = new DirectoryInfo(DIR + "//Warriors");

            // get all files with the .jpg extension
            FileInfo[] Files = info.GetFiles("*.jpg");

            // loop through each file
            foreach(FileInfo file in Files)
            {
                // get the name of the file
                String imageFileName = file.Name;
                String[] imgName = imageFileName.Split(delimiters);
                
                // check what tag the image has
                if(string.Compare(imgName[0], "H") == 0)
                {
                    // make the card and add it to the deck
                    Card c = new Card(imgName[1], " ", rnd.Next(100, 301), rnd.Next(100, 201), 0, DIR + "//Warriors//" + imageFileName);
                    c.SetType("Hero");
                    freshDeck.Add(c);
                }
                else if(string.Compare(imgName[0], "A") == 0)
                {
                    Card c = new Card(imgName[1], " ", rnd.Next(200, 401), rnd.Next(150, 201), 0, DIR + "//Warriors//" + imageFileName);
                    c.SetType("Assassin");
                    freshDeck.Add(c);
                }
                else if(string.Compare(imgName[0], "R") == 0)
                {
                    Card c = new Card(imgName[1], " ", rnd.Next(50, 101), rnd.Next(200, 301), 0, DIR + "//Warriors//" + imageFileName);
                    c.SetType("Horse");
                    freshDeck.Add(c);
                }
                else if(string.Compare(imgName[0], "T") == 0)
                {
                    Card c = new Card(imgName[1], " ", 0, 0, 0, DIR + "//Warriors//" + imageFileName);
                    c.SetType("Trap");
                    freshDeck.Add(c);
                }
                else if (string.Compare(imgName[0], "W") == 0)
                {
                    Card c = new Card(imgName[1], " ", rnd.Next(150, 201), rnd.Next(50, 101), 0, DIR + "//Warriors//" + imageFileName);
                    c.SetType("Weapon");
                    freshDeck.Add(c);
                }
            }

            return freshDeck;
        }

        // check if one of the players has reached 0 or less life points
        public bool CheckIfGameOver()
        {
            if(player1LifePoints <= 0 || player2LifePoints <= 0)
            {
                return true;
            }

            return false;
        }

        // recieve data from specified player, then compute based on protocol
        public void ReceiveDataFromPlayer(Socket player1, Socket player2, int currentPlayer)
        {
            Console.WriteLine("Recieving data from player " + currentPlayer);
            byte[] info = new byte[256];
            player1.Receive(info, SocketFlags.None);
            int protocol = GetProtocol(info);


            while (protocol != (int)PROTOCOL.ENDTURN)
            {


                // attack the player 
                if (protocol == (int)PROTOCOL.ATTACKPLAYER)
                {

                    ExectuteProtocolTwo(player1, player2, info, currentPlayer);

                    // once the attack is complete, check if the players health is below or equal to 0
                    if (CheckIfGameOver())
                    {
                        ExecuteProtocolFive(player2);
                        return;
                    }
                }
                else if (protocol == (int)PROTOCOL.PLACECARD) // this lets the players know if there was a card placed down
                {
                    ExecuteProtocolThree(player1, player2, info, currentPlayer);
                }
                else if (protocol == (int)PROTOCOL.ATTACKPLAYER)
                {
                    // attack the enemy's card with the player's card and determine who wins
                    ExecuteProtocolSix(player1, player2, info);
                }
                else if (protocol == (int)PROTOCOL.BUFFCARD)
                {
                    // this will enhance the card's stats depending on the stats of the card.
                    ExecuteProtocolSeven(player1, player2, info);
                }
                else if(protocol == (int)PROTOCOL.TRAPCARD)
                {
                    // this will randomly choose an enemy card and give it to the current player
                    ExecuteProtocolEight(player1, player2, info);
                }

                // wait to get information from the player.
                info = new byte[256];
                player1.Receive(info, SocketFlags.None);
                protocol = GetProtocol(info);
            }

            // let the other player know that they can start their turn
            player2.Send(Encoding.ASCII.GetBytes("4"));
        }
        
        // execute draw protocol
        public void DrawCardProtocol(Socket player1, Socket player2)
        {
            if(deck.Count >= 2)
            {
                Card player1Card = deck[0];
                Card player2Card = deck[1];
                deck.RemoveAt(0);
                deck.RemoveAt(0);

                String preparePlayer1Send = "1 " + player1Card.GetName() + " " + player1Card.GetAttack() + " " + player1Card.GetDefense() + "-";
                String preparePlayer2Send = "1 " + player2Card.GetName() + " " + player2Card.GetAttack() + " " + player2Card.GetDefense() + "-";

                player1.Send(Encoding.ASCII.GetBytes(preparePlayer1Send));
                player2.Send(Encoding.ASCII.GetBytes(preparePlayer2Send));
            }
        }


        // get the protocol from the raw data recieved
        private int GetProtocol(byte[] rawData)
        {
            String stringData = Encoding.ASCII.GetString(rawData);
            String protocol = "" + stringData[0];
            return Int32.Parse(protocol);
        }

        // executes protocol 3. 
        // Assumes input is valid.
        // This protocol takes 1 card that is a hero and subtracts the enemy's health points 
        private void ExectuteProtocolTwo(Socket p1, Socket p2, byte[] data, int currentPlayer)
        {
            String rawData = Encoding.ASCII.GetString(data);
            String cardRawData = rawData.Substring(2);

            String[] cardInfo = cardRawData.Split(' ');
            int attackDamage = Int32.Parse(cardInfo[1]);

            Console.WriteLine("raw string data: " + rawData);
            
            // deduct life points depending on who the current player is.
            if(currentPlayer == 1)
            {
                player2LifePoints -= attackDamage;
            }
            else if (currentPlayer == 2)
            {
                player1LifePoints -= attackDamage;
            }

            //format it to prepare to send over the socket
            String prepareToSend = "2 " + player1LifePoints.ToString() + " " + player2LifePoints;
            Console.WriteLine("preparing to send: " + prepareToSend);
            byte[] dataToSend = Encoding.ASCII.GetBytes(prepareToSend);

            // send information to both players
            updater.UpdateBothPlayers(p1, p2, dataToSend);
        }

        // exectute protocol 3
        // This protocol let's the other player 
        private void ExecuteProtocolThree(Socket p1, Socket p2, byte[] data, int currentPlayer)
        {
            p2.Send(data);
        }

        // this will end the game
        public void ExecuteProtocolFive(Socket p1)
        {
            String dataToSend = "5 ";
            p1.Send(Encoding.ASCII.GetBytes(dataToSend));
        }

        public void ExecuteProtocolSix(Socket p1, Socket p2, byte[] data)
        {
            // extract the raw byte data from the byte array
            String rawData = Encoding.ASCII.GetString(data);
            String cardRawData = rawData.Substring(2);
            String[] formatedCardData = cardRawData.Split('-');

            // turn the raw data into string information containing card information
            String currentTurnPlayerCard = formatedCardData[0];
            String currentTurnEnemyCard = formatedCardData[1];

            // get the attack value from the current player's card
            String[] playerCardAttributes = currentTurnPlayerCard.Split(' ');
            int atkValue = Int32.Parse(playerCardAttributes[1]);

            // get the defense value from the enemy's card
            String[] enemyCardAttributes = currentTurnEnemyCard.Split(' ');
            int defValue = Int32.Parse(enemyCardAttributes[2]);

            // determine the outcome of the card fight and return appropriate result to both players
            if (atkValue > defValue)
            {
                // create string protocol 
                String protocol = PROTOCOL.ATTACKPLAYER.ToString();
                // build string indicating defending card lost
                String defLost = protocol + " " + "0" + " " + currentTurnEnemyCard + "-";
                // build string attacking card won
                String atkWon = protocol + " " + "1" + " " + currentTurnPlayerCard + "-";

                p1.Send(Encoding.ASCII.GetBytes(atkWon));
                p2.Send(Encoding.ASCII.GetBytes(defLost));
            } else
            {
                // create string protocol 
                String protocol = PROTOCOL.ATTACKPLAYER.ToString();
                // build string indicating defending card lost
                String defWon = protocol + " " + "1" + " " + currentTurnEnemyCard + "-";
                // build string attacking card won
                String atkLost = protocol + " " + "0" + " " + currentTurnPlayerCard + "-";

                // send the data
                p1.Send(Encoding.ASCII.GetBytes(atkLost));
                p2.Send(Encoding.ASCII.GetBytes(defWon));
            }

        }

        public void ExecuteProtocolSeven(Socket p1, Socket p2, byte[] data)
        {
            // extract the raw byte data from the byte array
            String rawData = Encoding.ASCII.GetString(data);
            String cardRawData = rawData.Substring(2);
            String[] formatedCardData = cardRawData.Split('-');

            // turn the raw data into string information containing card information
            String heroCard = formatedCardData[0];
            String buffingCard = formatedCardData[1];

            // get the attack and defense values from the current player's card
            String[] heroCardAttributes = heroCard.Split(' ');
            int heroAtkValue = Int32.Parse(heroCardAttributes[1]);
            int heroDefValue = Int32.Parse(heroCardAttributes[2]);

            // get the stats from the buffing card
            String[] buffingCardAttributes = buffingCard.Split(' ');
            int buffAtkValue = Int32.Parse(buffingCardAttributes[1]);
            int buffDefValue = Int32.Parse(buffingCardAttributes[2]);

            // create a new card with updated values
            int buffedAtk = heroAtkValue + buffAtkValue;
            int buffedDef = heroDefValue + buffDefValue;

            // turn information into strings and get the proper protocol
            String buffedHeroCard = heroCardAttributes[0] + " " + buffedAtk.ToString() + " " + buffedDef.ToString() + "-";
            String protocol = "7";

            // store it in sending format
            String newCardToSend = protocol + " " + buffedHeroCard + buffingCard;

            // send to player
            p1.Send(Encoding.ASCII.GetBytes(newCardToSend));
            p2.Send(Encoding.ASCII.GetBytes(newCardToSend));

        }

        public void ExecuteProtocolEight(Socket p1, Socket p2, byte[] data)
        {
            

            // extract the raw byte data from the byte array
            String rawData = Encoding.ASCII.GetString(data);
            String cardRawData = rawData.Substring(2);
            String[] formatedCardData = cardRawData.Split('-');
            Console.WriteLine("THIS IS RAW: " + rawData);

            // get the number of cards the enemy currently has on the field
            int numberOfCards = formatedCardData.Length;

            // randomly choose an index from 0 to the size of the array
            Random rnd = new Random();
            int cardPosition = rnd.Next(1, numberOfCards);

            // get the card to take and the proper protocol to send
            String cardToTake = formatedCardData[cardPosition] + "-";
            String protocol = "8";
            // PROTOCOL.TRAPCARD.ToString();

            // create the proper format to send it in
            String formattedDataToSend = protocol + " " + formatedCardData[0] + "-"+ cardToTake;

            // send card to both players
            p1.Send(Encoding.ASCII.GetBytes(formattedDataToSend));
            p2.Send(Encoding.ASCII.GetBytes(formattedDataToSend));
        }
    }
}
