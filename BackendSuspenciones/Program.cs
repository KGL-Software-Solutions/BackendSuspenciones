using BackendSuspenciones.Interfaces;
using BackendSuspenciones.Services;

var builder = WebApplication.CreateBuilder(args);

// Agrega los servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inyecta tu servicio
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

var app = builder.Build();

// Configura el middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// app.UseAuthorization(); // Solo si usas autenticación

app.MapControllers(); // Mapea tus rutas

app.Run();
