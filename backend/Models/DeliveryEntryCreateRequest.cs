namespace BottleDeliveryTracker.Models;

public sealed class DeliveryEntryCreateRequest
{
    public DateTime Date { get; set; } = DateTime.Today;
    public int BottleCount { get; set; }
}
