using apiCSHARP.apiAluguel.Models;

public static class Rota_DELETE
{
    public static void MapDeleteRoutes(this WebApplication app)
    {
        app.MapDelete("/api/alugueis/{id}", async (int id, Locatarios Dados) =>
        {
            var locacao = await Dados.Locacoes.FindAsync(id);
            if (locacao is null) return Results.NotFound();

            Dados.Locacoes.Remove(locacao);

            await Dados.SaveChangesAsync();
            return Results.Ok();
        });
    }
}
