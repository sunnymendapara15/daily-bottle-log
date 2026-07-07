namespace BottleDeliveryTracker.Models;

public sealed class DeliveryEntry
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int BottleCount { get; set; }
}
