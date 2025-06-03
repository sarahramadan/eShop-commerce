namespace BuildingBlocks.Messaging.Event;

public record IntegrationEvent
{
    public IntegrationEvent()
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
    }
    public Guid Id { get; init; }
    public DateTime CreationDate { get; init; }
    public string EventType => GetType().Name;
    public override string ToString() => $"{EventType} - {Id} - {CreationDate}";

}





