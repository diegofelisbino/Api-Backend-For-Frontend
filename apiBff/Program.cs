using apiBff.Interfaces;
using apiBff.Services;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Exemplo API Bff - BackEnd for FrontEnd",
        Version = "v1"

    });
});

/*builder.Services
    .AddRefitClient<ICadastroService>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri("http://localhost:5207/");
    });*/

builder.Services.AddScoped<ICadastroService, CadastroService>();
builder.Services.AddScoped<IOperacionalService, OperacionalService>();
builder.Services.AddScoped<IFrontAgendamentoService, FrontAgendamentoService>();

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
