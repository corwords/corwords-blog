namespace Corwords.Core
{
    public class TransactionMessage
    {
        public string MessageKey { get; set; }
        public string Message { get; set; }
        public bool DisplayMessage { get; set; }

        public TransactionMessage()
        {
            MessageKey = "default";
            Message = "";
            DisplayMessage = true;
        }

        public TransactionMessage(string message)
        {
            MessageKey = "default";
            Message = message;
            DisplayMessage = true;
        }

        public TransactionMessage(string key, string message)
        {
            MessageKey = key;
            Message = message;
            DisplayMessage = true;
        }

        public TransactionMessage(string message, bool display)
        {
            MessageKey = "default";
            Message = message;
            DisplayMessage = display;
        }

        public TransactionMessage(string key, string message, bool display)
        {
            MessageKey = key;
            Message = message;
            DisplayMessage = display;
        }
    }
}