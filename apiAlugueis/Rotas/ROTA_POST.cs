using apiAlugueis.Models;

public static class Rota_POST
{
    public static void MapPostRoutes(this WebApplication app)
    {
        app.MapPost("/alugueis", async (Aluguel aluguel, Alugueis Dados) =>
        {
            Dados.Alugueis.Add(aluguel);
            await Dados.SaveChangesAsync();
            return Results.Created($"/alugueis/{aluguel.Id}", aluguel);
        });
    }
}
