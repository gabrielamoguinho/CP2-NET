using FinanceControl.Application.Services;
using FinanceControl.Domain.Interfaces;
using FinanceControl.Infrastructure.Context;
using FinanceControl.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.OpenApi.Models; 

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "FinanceControl", Version = "v1" });
    options.ExampleFilters(); 
});

builder.Services.AddSwaggerExamplesFromAssemblyOf<UsuarioRequestExample>();

builder.Services.AddDbContext<FinanceDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ILancamentoRepository, LancamentoRepository>();
builder.Services.AddScoped<LancamentoService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<UsuarioService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
