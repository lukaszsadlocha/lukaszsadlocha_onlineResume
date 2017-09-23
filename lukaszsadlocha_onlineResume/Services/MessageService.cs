using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lukaszsadlocha_onlineresume.Services
{
    public static class MessageService
    {
        public static string GetMessageOnType(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Success:
                    return "Your email has been added - thank you";
                case MessageType.Error:
                    return "Sorry, I coundn't validate your email addres or save it. Your email hasn,t been added";
                default:
                    throw new ArgumentException("{0} Message type is not handled!", Enum.GetName(typeof(MessageType), messageType));
            }
        }
    }

    public enum MessageType
    {
        Success,
        Error
    }
}
