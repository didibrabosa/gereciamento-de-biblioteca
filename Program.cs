using InventarioLivros.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<InventarioContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaltConnection"),
        new MySqlServerVersion(new Version(8, 0, 23))
    )
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();