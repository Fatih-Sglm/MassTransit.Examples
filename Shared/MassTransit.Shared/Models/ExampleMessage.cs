namespace MassTransit.Shared.Models
{
    public class ExampleMessage : BaseMessage
    {
        public required string Topic { get; set; }
        public required string Text { get; set; }
        public required string WriterBy { get ; set; }
    }
}
