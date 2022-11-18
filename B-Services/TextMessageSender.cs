using B_Interfacese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Services
{
    public class TextMessageSender : IMessageSender
    {
        public string SendMessage(string subject, string from, string to, string message)
        {
            return "(" + to + ") envio el mensaje: [" + message +
               "] via (Mensaje de Texto) con el asunto [" + subject + "] a (" + to + ")";
        }
    }
}
