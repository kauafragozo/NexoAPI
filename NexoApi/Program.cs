using Microsoft.EntityFrameworkCore;
using NexoApi.Data;
using Pomelo.EntityFrameworkCore.MySql;
using  Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();


string? MySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseMySql(MySqlConnection,
ServerVersion.AutoDetect(MySqlConnection)));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference("/scalar/v1");
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
