using Microsoft.EntityFrameworkCore;
using apiAlugueis.Models;
using apiAlugueis.Rotas;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Alugueis>(options => options.UseSqlite("Data Source=alugueis.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();
app.UseCors("AllowAll");

// Mapeia as rotas REST
app.MapGetRoutes();
app.MapPostRoutes();
app.MapPutRoutes();
app.MapDeleteRoutes();

// Popular o banco com dados iniciais, se estiver vazio
PopularBancoDeDados(app);

// Inicia a aplicação
app.Run();

void PopularBancoDeDados(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var Dados = scope.ServiceProvider.GetRequiredService<Locatarios>();

    Dados.Database.Migrate();

    if (Dados.Locatarios.Any()) { return; }

    var pessoasIniciais = new List<Pessoa>
    {
        new Pessoa { id = 1, nome = 'Carlos', sobrenome = 'Silva', cpf = '12345678901' }
    }

    Dados.Locatarios.AddRange(pessoasIniciais);
    Dados.SaveChanges();
}