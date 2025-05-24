using Microsoft.EntityFrameworkCore;

namespace apiCSHARP.Models
{
    public class Alugueis : DbContext
    {
        public Alugueis(DbContextOptions<Alugueis> options) : base(options) { }
        public DbSet<Aluguel> Alugueis { get; set; }
    }
}