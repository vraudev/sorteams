using VRAU.Sorteams.Domain.Context;
using VRAU.Sorteams.WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);

#region Configurations

DependencyInjectionSetup.AddDependencyInjectionSetup(builder.Services);

DatabaseSetup.AddDatabaseSetup(builder.Services, builder.Configuration);

#endregion

// Add services to the container.

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

app.Run();