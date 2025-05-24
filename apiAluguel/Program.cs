using Microsoft.EntityFrameworkCore;
using apiCSHARP.apiAluguel.Models;
using apiCSHARP.apiAluguel.Rotas;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Locatarios>(options => options.UseSqlite("Data Source=locacoes.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();
app.UseCors("AllowAll");

app.MapGetRoutes();
app.MapPostRoutes();
app.MapDeleteRoutes();

PopularBancoDeDados(app);

app.Run();

void PopularBancoDeDados(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var Dados = scope.ServiceProvider.GetRequiredService<Locatarios>();

    Dados.Database.Migrate();

    if (Dados.Locacoes.Any()) { return; }

    var locacoesIniciais = new List<Pessoa>
    {
        new() {}
    };

    Dados.Locacoes.AddRange(locacoesIniciais);
    Dados.SaveChanges();
}
