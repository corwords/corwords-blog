using System.Collections.Generic;

namespace Corwords.Core
{
    public class TransactionStatus
    {
        public bool Success { get; set; }
        public List<TransactionMessage> Messages { get; set; }

        public TransactionStatus()
        {
            Success = true;
            Messages = new List<TransactionMessage>();
        }

        public TransactionStatus(bool success)
        {
            Success = success;
            Messages = new List<TransactionMessage>();
        }

        public TransactionStatus(string message)
        {
            Success = false;
            Messages = new List<TransactionMessage> { new TransactionMessage(message) };
        }

        public TransactionStatus(bool success, string message)
        {
            Success = success;
            Messages = new List<TransactionMessage> { new TransactionMessage(message) };
        }

        public TransactionStatus(bool success, string message, bool displayMessage)
        {
            Success = success;
            Messages = new List<TransactionMessage> { new TransactionMessage(message, displayMessage) };
        }

        public void AddFailMessage(string message)
        {
            Success = false;
            Messages.Add(new TransactionMessage(message));
        }

        public void AddFailMessage(string message, bool displayMessage)
        {
            Success = false;
            Messages.Add(new TransactionMessage(message, displayMessage));
        }

        public void AddFailMessage(string key, string message, bool displayMessage)
        {
            Success = false;
            Messages.Add(new TransactionMessage(key, message, displayMessage));
        }
    }
}