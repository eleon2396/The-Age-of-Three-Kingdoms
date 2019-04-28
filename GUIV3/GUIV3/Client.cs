using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


// THIS IS THE CLIENT

namespace ClientNetwork
{
    class Client
    {
        private Socket client;
        private IPAddress hostEntry;
        private IPEndPoint ep;
        private int isFirstPlayer;
        private TcpClient tcp_ngrok;
        private readonly String tcp_address = "0.tcp.ngrok.io";
        private readonly int ngrok_port = 13242;


        public Client()
        {
            // set up client socket
            /* this.client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
             this.hostEntry = Dns.GetHostEntry(Dns.GetHostName()).AddressList[6];
             this.ep = new IPEndPoint(hostEntry, 9315);*/
            try
            {
                this.tcp_ngrok = new TcpClient(this.tcp_address, this.ngrok_port);
            }
            catch (Exception ex)
            {

            }

            this.isFirstPlayer = -1;
        }

        public int CheckIsFirstPlayer()
        {
            return isFirstPlayer;
        }

        public async Task ConnectToServer()
        {
            // connect to the server
            // client.Connect(ep);
            client = tcp_ngrok.Client;
            // get the starting match data
            byte[] startInfo = await RecServerData();
            byte protocol = startInfo[0];
            int playerAssignment = (int)startInfo[1];

            // hold onto information about whether user is first player or not
            if (playerAssignment == 1)
            {
                // you are player 1, you go first
                isFirstPlayer = 1;
                Console.WriteLine("You are player 1");
            }
            else
            {
                // you are not player 1, you dont go first
                isFirstPlayer = 0;
                Console.WriteLine("You are player 2");
            }
        }
        

        // send information to the server
        public void SendToServer(String data)
        {
            client.Send(Encoding.ASCII.GetBytes(data));
        }

        // wait on some data that might be recieved from the server
        public async Task<byte[]> RecServerData()
        {
            // start an async task
            Task<Byte[]> task = new Task<Byte[]>(WaitForData);
            task.Start();

            // wait for task to finish
            Byte[] serverData = await task;

            // send the payload back
            return serverData;
        }

        private byte[] WaitForData()
        {
            // recieve the server data
            byte[] info = new byte[256];
            client.Receive(info, 0, 256, SocketFlags.None);
            return info;
        }
    }
}
