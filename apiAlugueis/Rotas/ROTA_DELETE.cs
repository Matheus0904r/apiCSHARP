using apiAlugueis.Models;
public static class Rota_DELETE
{
    public static void MapDeleteRoutes(this WebApplication app)
    {
        app.MapDeleteRoutes("/alugueis/{id}", async (int id, Locatarios Dados) =>
        {
            var locacao = await Dados.Locatarios.FindAsync(id);
            if (locacao is null) return Results.NotFound();

            Dados.Locatarios.Remove(locacao);
            await Dados.SaveChangesAsync();
            return Results.Ok();

        })
    }
}