using Microsoft.EntityFrameworkCore;
using Trabalho4SemestreApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Contexts>
    (options => options.UseMySql(
        "server=localhost;initial catalog=RestaurantesLondrina;uid=root;pwd=",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.26-mysql")));

var app = builder.Build();

// Configure the HTTP request pipeline.
 

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
