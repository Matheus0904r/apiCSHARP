using Microsoft.EntityFrameworkCore;
using apiCSHARP.apiAluguel.Models;

public static class Rota_PUT
{
    public static void MapPutRoutes(this WebApplication app)
    {
        app.MapPut("/alugueis/{id}", async (int id, Pessoa pessoa, Locatarios Dados) =>
        {
            
        });
    }
}
