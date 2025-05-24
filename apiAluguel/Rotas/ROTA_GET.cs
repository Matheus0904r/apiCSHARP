using Microsoft.EntityFrameworkCore;
using apiCSHARP.apiAluguel.Models;

namespace apiCSHARP.apiAluguel.Rotas
{
    public static class Rota_GET
    {
        public static void MapGetRoutes(this WebApplication app)
        {
            app.MapGet("/api/alugueis", async (Locatarios Dados) =>
            {
                var locacoes = await Dados.Locacoes.ToListAsync();
                return Results.Ok(locacoes);
            });

            app.MapGet("/api/alugueis/{id}", async (int id, Locatarios Dados) =>
            {
                var locacao = await Dados.Locacoes.FindAsync(id);
                return locacao is not null ? Results.Ok(locacao) : Results.NotFound();
            });
        }
    }
}
