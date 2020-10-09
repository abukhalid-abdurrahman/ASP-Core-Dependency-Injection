namespace DI
{
    class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Send via SMS";
        }
    }
}