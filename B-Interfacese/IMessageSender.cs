using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Interfacese
{
    public interface IMessageSender
    {
        string SendMessage(string subject,string from,string to, string message);
    }
}
