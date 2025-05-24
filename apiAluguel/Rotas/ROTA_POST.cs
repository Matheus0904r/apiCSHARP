using apiCSHARP.apiAluguel.Models;

public static class Rota_POST
{
    public static void MapPostRoutes(this WebApplication app)
    {
        app.MapPost("/api/alugueis", async (Pessoa pessoa, Locatarios Dados) =>
        {
            Dados.Locacoes.Add(pessoa);
            await Dados.SaveChangesAsync();
            return Results.Created($"/api/alugueis/{pessoa.Id}", pessoa);
        });

        app.MapPost("/api/imoveis", async (Imovel imovel, portifolio Dados) =>
        {
            Dados.Imoveis.Add(imovel);
            await Dados.SaveChangesAsync();
            return Results.Created($"/api/imoveis/{imovel.Id}", imovel);
        });
    }
}
