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

        app.MapDelete("/api/imoveis/{id}", async (int id, portifolio Dados) =>
        {
            var imovel = await Dados.Imoveis.FindAsync(id);
            if (imovel is null) return Results.NotFound();

            Dados.Imoveis.Remove(imovel);

            await Dados.SaveChangesAsync();
            return Results.Ok();
        });
    }
}
