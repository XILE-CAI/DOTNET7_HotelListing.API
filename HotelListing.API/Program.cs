using HotelListing.API.Configurations;
using HotelListing.API.Data;
using HotelListing.API.IRepository;
using HotelListing.API.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<HotelListingDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelListingDbConnectingString"));
});

builder.Services.AddControllers();

//add automapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

//apply repository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ICountriesRepository, CountriesRepository>();
builder.Services.AddScoped<IHotelsRepository, HotelsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline. middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
