using TwitchLib;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;

using System;
using System.Diagnostics;

namespace hmmubot
{
    internal class TwitchChatBot
    {
        readonly ConnectionCredentials credentials = new ConnectionCredentials(info.BotUsername, info.BotToken);
        TwitchClient client;
        Stopwatch stopwatch;

        public TwitchChatBot()
        {
            
        }
        //hmmus bot
        internal void Connecthmmu()
        {
            stopwatch = new Stopwatch();
            Console.WriteLine("connected to hmmus chat, starting stopwatch");
            stopwatch.Start();
            client = new TwitchClient();
            client.Initialize(credentials, info.Channelhmmmu);
            client.OnMessageReceived += Client_OnMessageReceivedhmmu;
            client.OnConnectionError += Client_OnConnectionError;
            client.OnDisconnected += Client_OnDisconnected;
            client.Connect();
        }

        private void Client_OnMessageReceivedhmmu(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.StartsWith("!enation", StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage(info.Channelhmmmu, $"/me POSTURE NATION 👌 OMGScoods");
            }

            else if (stopwatch.Elapsed.Hours >= 2)
            { 
            client.SendMessage(info.Channelhmmmu, $"/me : OMGScoods 👆 Friendly reminder to check your posture FeelsOkayMan");
            stopwatch.Restart();
            }
        }
        //forsens bot
        internal void Connectforsen()
        {
            stopwatch = new Stopwatch();
            Console.WriteLine("connected to forsens chat, starting stopwatch");
            stopwatch.Start();
            client = new TwitchClient();
            client.Initialize(credentials, info.Channelforsen);
            client.OnMessageReceived += Client_OnMessageReceivedforsen;
            client.OnConnectionError += Client_OnConnectionError;
            client.OnDisconnected += Client_OnDisconnected;
            client.Connect();
        }

        private void Client_OnMessageReceivedforsen(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.StartsWith("!enation", StringComparison.InvariantCultureIgnoreCase))
            {
                client.SendMessage(info.Channelforsen, $"/me POSTURE NATION 👌 OMGScoods");
            }

            else if (stopwatch.Elapsed.Hours >= 2)
            {
                client.SendMessage(info.Channelforsen, $"/me : OMGScoods 👆 Friendly reminder to check your posture FeelsOkayMan");
                stopwatch.Restart();
            }
        }
        //nymns bot
        internal void Connectnymn()
        {
            stopwatch = new Stopwatch();
            Console.WriteLine("connected to nymns chat, starting stopwatch");
            stopwatch.Start();
            client = new TwitchClient();
            client.Initialize(credentials, info.Channelnymn);
            client.OnMessageReceived += Client_OnMessageReceivednymn;
            client.OnConnectionError += Client_OnConnectionError;
            client.OnDisconnected += Client_OnDisconnected;
            client.Connect();
        }

        private void Client_OnMessageReceivednymn(object sender, OnMessageReceivedArgs e)
        {
            if (stopwatch.Elapsed.Hours >= 2)
            {
                client.SendMessage(info.Channelnymn, $"/me : OMGScoods 👆 Friendly reminder to check your posture FeelsOkayMan");
                stopwatch.Restart();
            }
        }
        //pajs bot
        internal void ConnectPajlada()
        {
            stopwatch = new Stopwatch();
            Console.WriteLine("connected to pajladas chat, starting stopwatch");
            stopwatch.Start();
            client = new TwitchClient();
            client.Initialize(credentials, info.ChannelPajlada);
            client.OnMessageReceived += Client_OnMessageReceivedPajlada;
            client.OnConnectionError += Client_OnConnectionError;
            client.OnDisconnected += Client_OnDisconnected;
            client.Connect();
        }

        private void Client_OnMessageReceivedPajlada(object sender, OnMessageReceivedArgs e)
        {
            if (stopwatch.Elapsed.Hours >= 2)
            {
                client.SendMessage(info.ChannelPajlada, $"/me : OMGScoods 👆 Friendly reminder to check your posture FeelsOkayMan");
                stopwatch.Restart();
            }
        }


        private void Client_OnDisconnected(object sender, OnDisconnectedArgs e)
        {
            client.Reconnect();
        }
        private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            Console.WriteLine($"Error!!! {e.Error}");
        }

        internal void Disconnect()
        {
            Console.WriteLine("Disconnecting");
        }
    }

}