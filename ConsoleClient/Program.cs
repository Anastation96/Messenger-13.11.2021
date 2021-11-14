using System;
using ASPCoreServer;
using Newtonsoft.Json;

namespace Messenger_13._11._2021
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static MessengerClientAPI API = new MessengerClientAPI();

        private static void GetNewMessages()
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                Console.WriteLine("Введите сообщение: ");
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }

        static void Main(string[] args)
        {
            //Message msg = new Message("Anastation", "Привет!", DateTime.UtcNow);
            //string output = JsonConvert.SerializeObject(msg);
            //Console.WriteLine(output);
            //Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            //Console.WriteLine(deserializedMsg);
            //{ "UserName":"Anastation","MessageText":"Привет!","TimeStamp":"2021-11-13T16:52:40.3339576Z"}
            //Anastation < 13.11.2021 16:52:40 >: Привет!
            //Console.WriteLine("Start project!");
            //Console.WriteLine(msg.ToString());
            MessageID = 1;
            Console.WriteLine("Введите ваше имя: ");
            UserName = Console.ReadLine();
            Console.WriteLine("Введите сообщение: ");
            string MessageText = "";
            while (MessageText != "exit")
            {
                GetNewMessages();
                MessageText = Console.ReadLine();
                if (MessageText.Length > 1)
                {
                    Message sendMessage = new Message(UserName, MessageText, DateTime.Now);
                    API.SendMessage(sendMessage);
                }
            }
        }
    }
}
