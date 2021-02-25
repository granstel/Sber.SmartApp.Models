namespace Sber.SmartApp.Models
{
    public class Request
    {
        public string MessageName { get; set; }

        public string SessionId { get; set; }

        public long MessageId { get; set; }

        public Uuid Uuid { get; set; }

        public Payload Payload { get; set; }
    }
}