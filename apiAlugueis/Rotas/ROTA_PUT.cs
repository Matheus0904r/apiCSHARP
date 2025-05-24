// using Microsoft.EntityFrameworkCore;
using apiAlugueis.Models;
using apiAlugueis.Models.Locatarios;

public static class Rota_PUT
{
    public static void MapPutRoutes(this WebApplication app)
    {
        app.MapPut("/alugueis/{id}", async (int id, Imovel imovel, Locatarios Dados) =>
        {
            // var imovel = await Dados.Alugueis.FindAsync(id);
            // if (imovel is null) return Results.NotFound();

            

            // livro.TituloLivro = input.TituloLivro;
            // livro.AutorLivro = input.AutorLivro;
            // livro.Ano = input.Ano;
            // livro.TipoMaterial = input.TipoMaterial;
            // livro.Citacao = input.Citacao;

            // await context.SaveChangesAsync();
            // return Results.Ok(livro);
        });
    }
}
