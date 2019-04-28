using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer;

namespace FuckingKillme
{
    class Program
    {
        static void Main(string[] args)
        {
            Server newServer = new Server();
            newServer.LookForConnections();
            //GameActions s = new GameActions();
            //s.ExecuteProtocolSix();

            Console.ReadKey();
            
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
