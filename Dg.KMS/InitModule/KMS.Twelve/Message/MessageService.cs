using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMS.Twelve.Message
{
    public class MessageService
    {
    }
    //[MessagePlatform(Enums.MPlatform.A平台)]
    public class ASendMessageService : IMessage
    {
        public decimal QueryBalance()
        {
            return 0;
        }

        public bool Send(string msg)
        {
            return true;
        }

        public int TotalSend(DateTime? startDate, DateTime? endDate)
        {
            return 100;
        }
    }
}
