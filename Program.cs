using MediatR;
using Microsoft.EntityFrameworkCore;
using PedidoApi.Data;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Configurando EF Core com banco em memória
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("PedidosDb"));

//Configurando MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
