using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace GameServer
{
    class Updater
    {
        private const int SIZE = 500;
        public Updater()
        {
            // nothing so far
        }

        // notify specific player of 
        public void UpdateOnePlayer(Socket player, Byte[] payload)
        {
            // send the data to the player
            player.Send(payload);
        }

        public void UpdateBothPlayers(Socket player1, Socket player2, Byte[] payload)
        {
            player1.Send(payload);
            player2.Send(payload);
        }
    }
}
