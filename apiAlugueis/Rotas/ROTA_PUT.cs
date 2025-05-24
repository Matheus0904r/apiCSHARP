// using Microsoft.EntityFrameworkCore;
using apiAlugueis.Models;
using apiAlugueis.Models.Locatarios;

public static class Rota_PUT
{
    public static void MapPutRoutes(this WebApplication app)
    {
        app.MapPut("/alugueis/{id}", async (int id, Pessoa pessoa, Locatarios Dados) =>
        {
            var imovel = await Dados.Locatarios.FindAsync(id);
            if (imovel is null) return Results.NotFound();

            pessoa.id_imovel = imovel.id;
            
            await Dados.SaveChangesAsync();
            return Results.Ok(pessoa);
        });
    }
}
