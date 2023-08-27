using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<HotelListingDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelListingDbConnectingString"));
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline. middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
