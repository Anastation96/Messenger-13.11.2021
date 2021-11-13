using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger_13._11._2021
{
    public class Message
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string userName, string messageText, DateTime timeStamp)
        {
            UserName = UserName;
            MessageText = messageText;
            TimeStamp = timeStamp;
        }

        public Message()
        {
            UserName = "System";
            MessageText = "Server is running...";
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            string output = String.Format("{0} <{2}>: {1}", UserName, MessageText, TimeStamp);
            return output;
        }
    }
}
