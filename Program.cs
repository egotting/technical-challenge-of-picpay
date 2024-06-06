using Models;
using Microsoft.EntityFrameworkCore;
using repositories;
using technical_challenge_of_picpay.Repositories;
using technical_challenge_of_picpay.Services;
using technical_challenge_of_picpay.Services.interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<ModelContext>(options =>
{
  options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();
builder.Services.AddScoped<ILogistaRepository, LogistaRepository>();
builder.Services.AddScoped<ILogistaServices, LogistaServices>();
builder.Services.AddScoped<ITransacaoRepository, TransacaoRepository>();
builder.Services.AddScoped<ITransacaoService, TransacaoService>();

var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoint => { endpoint.MapControllers(); });

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();


