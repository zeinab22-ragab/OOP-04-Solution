using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_04.Q3.Interface;

namespace OOP_04.Q3
{
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sms Notification => {recipient} , {message}");
        }
    }
}
