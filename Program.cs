using Exo.WebApi.Contexts;
using Exo.WebApi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<UsuarioRepository,
UsuarioRepository>();

// Add DbContext - IMPORTANTE: NÃO COMENTAR!
builder.Services.AddDbContext<ExoContext>();

// Add Repository
builder.Services.AddScoped<ProjetoRepository>();
// Add Repository
builder.Services.AddScoped<UsuarioRepository>();

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