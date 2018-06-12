using System;
namespace hmmubot
{
    class Program
    {
        static void Main(string[] args)
        {
            TwitchChatBot hmmubot = new TwitchChatBot();
            hmmubot.Connecthmmu();
            TwitchChatBot forsenbot = new TwitchChatBot();
            forsenbot.Connectforsen();
            TwitchChatBot nymnbot = new TwitchChatBot();
            nymnbot.Connectnymn();
            TwitchChatBot pajladabot = new TwitchChatBot();
            pajladabot.ConnectPajlada();
 
            Console.ReadLine();
            pajladabot.Disconnect();
            nymnbot.Disconnect();
            forsenbot.Disconnect();
            hmmubot.Disconnect();
        }
    }
}
