using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMS.Twelve.Message
{
    public interface IMessage
    {
        decimal QueryBalance();
        bool Send(string msg);
        int TotalSend(DateTime? startDate, DateTime? endDate);
    }
}
