using DesignPattern.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} : This Message has been sent using SMS");
        }
    }
}
