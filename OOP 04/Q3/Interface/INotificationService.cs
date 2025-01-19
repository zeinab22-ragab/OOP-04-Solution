using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Q3.Interface
{
    public interface INotificationService
    {
        void SendNotification(string recipient ,string message);
    }
}
