// using Microsoft.EntityFrameworkCore;
using apiAlugueis.Models.Locatarios;

namespace apiCSHARP.Rotas
{
    public static class Rota_GET
    {
        public static void MapGetRoutes(this WebApplication app)
        {
            app.MapGet("/alugueis", async(Locatarios Dados) =>
            {
                var locacoes = await Dados.Locacoes.ToListAsync();
                return Results.Ok(locacoes);
            });

            app.MapGet("/alugueis/{id}", async(int id, Locatarios Dados) =>
            {
                var locacao = await Dados.Locacoes.FindAsync(id);
                return locacao is not null ? Results.Ok(locacao) : Results.NotFound();
            });
        }
    }
}