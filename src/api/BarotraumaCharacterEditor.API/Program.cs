using BarotraumaCharacterEditor.API.Models;
using BarotraumaCharacterEditor.API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICharacterDataBlobRepository, CharacterDataBlobRepository>();
builder.Services.AddDbContext<CharacterDataBlobContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CharacterBlobDatabase")));

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

//try
//{
//    var dbContext = app.Services.GetRequiredService<CharacterDataBlobContext>();
//    dbContext.Database.Migrate();
//}
//catch (Exception ex)
//{
//    var logger = app.Logger;

//    logger.LogError(ex, "An error occurred while migrating or seeding the database.");

//    throw;
//}

app.Run();
