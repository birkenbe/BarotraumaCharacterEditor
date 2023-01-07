using BarotraumaCharacterEditor.API.Models;
using BarotraumaCharacterEditor.API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString= builder.Configuration.GetConnectionString("CharacterBlobDatabase");
builder.Services.AddDbContext<CharacterDataBlobContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<ICharacterDataBlobRepository, CharacterDataBlobRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

try
{
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<CharacterDataBlobContext>();
    dbContext.Database.Migrate();
}
catch (Exception ex)
{
    ILogger logger = app.Logger;

    logger.LogError(ex, "An error occurred while migrating or seeding the database.");

    throw;
}

app.Run();
