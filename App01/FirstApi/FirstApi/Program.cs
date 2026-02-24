using FirstApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<BooksDb> (opt => opt.UseInMemoryDatabase("BookList"));//InMemoryDatabase es una base de datos en memoria que se utiliza para pruebas y desarrollo. No requiere una configuración de base de datos externa y se borra cada vez que se reinicia la aplicación. Es útil para probar la funcionalidad de la aplicación sin necesidad de configurar una base de datos real, pero no es adecuada para entornos de producción debido a su naturaleza efímera.
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
