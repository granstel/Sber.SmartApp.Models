namespace Sber.SmartApp.Models
{
    public abstract class ContractBase
    {
        public string MessageName { get; set; }

        public string SessionId { get; set; }

        public long MessageId { get; set; }

        public Uuid Uuid { get; set; }

        public RequestPayload Payload { get; set; }
    }
}
