using Microsoft.EntityFrameworkCore;
using apiCSHARP.apiAluguel.Models;
using apiCSHARP.apiAluguel.Rotas;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Locatarios>(options => options.UseSqlite("Data Source=locacoes.db"));
builder.Services.AddDbContext<portifolio>(options => options.UseSqlite("Data Source=imoveis.db"));

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
    var locatariosContext = scope.ServiceProvider.GetRequiredService<Locatarios>();
    var portifolioContext = scope.ServiceProvider.GetRequiredService<portifolio>();

    locatariosContext.Database.Migrate();
    portifolioContext.Database.Migrate();

    if (!locatariosContext.Locacoes.Any())
    {
        var locacoesIniciais = new List<Pessoa>
        {
            new() { Id = 1, Nome = "João", Sobrenome = "Silva", CPF = "123.456.789-00", IdImovel = 1 },
            new() { Id = 2, Nome = "Maria", Sobrenome = "Oliveira", CPF = "987.654.321-00", IdImovel = 2 },
            new() { Id = 3, Nome = "Pedro", Sobrenome = "Santos", CPF = "456.789.123-00", IdImovel = 3 }
        };

        locatariosContext.Locacoes.AddRange(locacoesIniciais);
        locatariosContext.SaveChanges();
    }

    if (!portifolioContext.Imoveis.Any())
    {
        var imoveisIniciais = new List<Imovel>
        {
            new() { Id = 1, Endereco = "Rua A, 123", ValorAluguel = 1500, Metragem = 50 },
            new() { Id = 2, Endereco = "Rua B, 456", ValorAluguel = 2000, Metragem = 100 },
            new() { Id = 3, Endereco = "Rua C, 789", ValorAluguel = 3000, Metragem = 150 }
        };

        portifolioContext.Imoveis.AddRange(imoveisIniciais);
        portifolioContext.SaveChanges();
    }
}
