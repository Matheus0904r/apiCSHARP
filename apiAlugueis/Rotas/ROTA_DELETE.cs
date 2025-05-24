using apiAlugueis.Models;
public static class Rota_DELETE
{
    public static void MapDeleteRoutes(this WebApplication app)
    {
        app.MapDeleteRoutes("/alugueis/{id}", async (int id, Alugueis Dados) =>
        {

            var aluguel = await Dados.Alugueis.FindAsync(id);
            if (aluguel is null) return Results.NotFound();

            Dados.Alugueis.Remove(aluguel);
            await Dados.SaveChangesAsync();
            return Results.Ok();

        })
    }
}