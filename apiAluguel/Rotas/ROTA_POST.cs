using apiCSHARP.apiAluguel.Models;

public static class Rota_POST
{
    public static void MapPostRoutes(this WebApplication app)
    {
        app.MapPost("/alugueis", async (Pessoa pessoa, Locatarios Dados) =>
        {
            Dados.Locacoes.Add(pessoa);
            await Dados.SaveChangesAsync();
            return Results.Created($"/alugueis/{pessoa.Id}", pessoa);
        });
    }
}
