using System.Collections.Generic;

namespace Corwords.Core
{
    public class TransactionStatus
    {
        public bool Success { get; set; }
        public List<TransactionMessage> Messages { get; set; }

        public TransactionStatus()
        {
            Messages = new List<TransactionMessage>();
        }

        public TransactionStatus(bool success, string message)
        {
            Success = success;
            Messages = new List<TransactionMessage> { new TransactionMessage(message) };
        }
    }
}