using System;
using Newtonsoft.Json;

namespace Messenger_13._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Anastation", "Привет!", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"Anastation","MessageText":"Привет!","TimeStamp":"2021-11-13T16:52:40.3339576Z"}
            //Anastation < 13.11.2021 16:52:40 >: Привет!
            //Console.WriteLine("Start project!");
            //Console.WriteLine(msg.ToString());
        }
    }
}
