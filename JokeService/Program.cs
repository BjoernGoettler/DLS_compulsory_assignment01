using Microsoft.EntityFrameworkCore;
using JokeService.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
string connectionString = "Server=joke-db; User ID=svendbent; Password=henningipressening; Database=common";
builder.Services.AddDbContext<JokeContext>(
    opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
    );
// Add services to the container.
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
app.MapControllers();
app.UseHttpsRedirection();
app.Run();
