using Microsoft.EntityFrameworkCore;
using apiAlugueis.Models;

namespace apiCSHARP.Rotas
{
    public static class Rota_GET
    {
        public static void MapGetRoutes(this WebApplication app)
        {
            app.MapGet("/alugueis", async(Alugueis Dados) =>
            {
                var alugueis = await Dados.Alugueis.ToListAsync();
                return Results.Ok(alugueis);
            })

            app.MapGet("/alugueis/{id}", async(int id, Alugueis Dados) =>
            {
                var aluguel = await Dados.Alugueis.FindAsync(id);
                return aluguel is not null ? Results.Ok(aluguel) : Results.NotFound();
            })
        }
    }
}