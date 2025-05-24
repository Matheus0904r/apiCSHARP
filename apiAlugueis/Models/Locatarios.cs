namespace apiAlugueis.Models
{
    public class Locatario : DbContext
    {
        public Locatarios(DbContextOptions<Locatarios> options) : base(options) { }
        public DbSet<Pessoa> Locatarios { get; set; }

    }
}