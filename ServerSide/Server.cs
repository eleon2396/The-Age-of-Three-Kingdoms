using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;

namespace GameServer
{
    class Server
    {
        // init server variables
        private int port;
        private String host;
        private IPAddress hostip;
        private IPEndPoint ep;
        private Socket server;

        private TcpListener listener;
        private readonly String tcp_address = "0.tcp.ngrok.io";
        private readonly int ngrok_port = 11355;


        public Server()
        {
            // create a port
            this.port = 9315;

            // get the name of the pc
            this.host = Dns.GetHostName();
            // get the ip address of this pc. Make sure it is an ipv4 address
            //this.hostip = Dns.GetHostEntry(host).AddressList[3];
            //Console.WriteLine(hostip);
            /* This gets me the remote ip address */
            TcpClient tcp = new TcpClient(tcp_address, ngrok_port);
            string ip_port = tcp.Client.RemoteEndPoint.ToString();
            string ip = ip_port.Substring(0, ip_port.IndexOf(':'));

            tcp.Close();
            // run this if all hell breaks lose.
            //foreach (IPAddress s in Dns.GetHostEntry(host).AddressList)
            //{
            //    Console.WriteLine(s);
            //}
            this.hostip = IPAddress.Parse(ip); 
            // create an endpoint. i.e create a pipe with the ip address and specific port
            this.ep = new IPEndPoint(IPAddress.Any, this.port);

            // this.ep = new IPEndPoint(hostip, port);
            this.listener = new TcpListener(this.hostip, this.ngrok_port); // Access the server that ngrok is hosting
            // create a socket that will act as the sever and bind it.
            //this.server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.server = this.listener.Server; // now make me the server
            this.server.Bind(ep); // bind my port to ngrok server
        }

        public void LookForConnections()
        {
            server.Listen(5);
            Console.WriteLine("Server is listening...");
            Socket player_0 = server.Accept(); // catch the first TcpClient instance from the constructer created
            player_0.Close(); // close that port 
            // constantly keep looking for 2 connections at a time to group them together and start a match.
            while (true)
            {
                Console.WriteLine("Looking for players...");

                // accept 2 socket connections then begin the match protocol
                Socket player1 = server.Accept();
                Console.WriteLine("Player 1 connected!...");

                Socket player2 = server.Accept();
                Console.WriteLine("Player 2 connected!...");

                // create a new thread and throws both socket connections in there 
                Console.WriteLine("Creating a new Game Match...");
                Thread newMatch = new Thread(() => StartMatchProtocol(player1, player2));
                newMatch.Start();
            }
        }

        // function that takes in two socket connections (the players) and does the card game protocol
        public static void StartMatchProtocol(Socket p1, Socket p2)
        {
            // keep a turn timer to check whos turn it should be
            int turnCounter = 1;

            // Create a new instance of GameActions that will perform game tasks. will update players.
            GameActions game = new GameActions();

            // determine which player will be player 1 and inform both players. This determines who goes first.
            game.ChooseFirstPlayer(p1, p2);

            // shuffle cards and deal them to the players
            game.DealKingdomCards(p1, p2);

            try
            {
                while (game.CheckIfGameOver() == false)
                {
                    // draw a card each round
                    if (turnCounter >= 3 && turnCounter % 2 == 1)
                    {
                        game.DrawCardProtocol(p1, p2);
                    }

                    // who goes next?
                    if (turnCounter % 2 == 1)
                    {
                        game.ReceiveDataFromPlayer(p1, p2, 1);
                    }
                    else
                    {
                        game.ReceiveDataFromPlayer(p2, p1, 2);
                    }


                    turnCounter++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Game is Over!");
        }
    }
}
