using BottleDeliveryTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BottleDeliveryTracker.Data;

public sealed class BottleContext : DbContext
{
    public BottleContext(DbContextOptions<BottleContext> options) : base(options)
    {
    }

    public DbSet<DeliveryEntry> Deliveries { get; set; } = null!;
}
