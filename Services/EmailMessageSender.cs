namespace DI
{
    class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Send via Email";
        }
    }
}