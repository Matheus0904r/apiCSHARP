using Microsoft.EntityFrameworkCore;
using apiAlugueis.Models;
using apiAlugueis.Models.Pessoa;


namespace apiAlugueis.Models.Locatarios
{
    public class Locatarios : DbContext
    {
        public Locatarios(DbContextOptions<Locatarios> options) : base(options) { }
        public DbSet<Pessoa> Locacoes { get; set; }

    }
}