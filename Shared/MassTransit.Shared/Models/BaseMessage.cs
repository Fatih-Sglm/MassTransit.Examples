namespace MassTransit.Shared.Models
{
    public abstract class BaseMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
