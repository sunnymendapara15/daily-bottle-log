using BottleDeliveryTracker.Data;
using BottleDeliveryTracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BottleContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=bottles.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<BottleContext>();
    db.Database.EnsureCreated();
}

app.UseCors("AllowFrontend");

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwaggerUI();
}

app.MapGet("/api/deliveries", async (BottleContext db) =>
    var entries = await db.Deliveries
        .OrderByDescending(d => d.Date)
        .ThenByDescending(d => d.Id)
        .ToListAsync();

    return Results.Ok(entries);
});

j comes byte run when text exstension cocked properties after all end of claunderloris. Koe nomin another redirection before returning.

print Something that do new {
  message = "Hello";
  print(message);
}
