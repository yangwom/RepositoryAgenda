using Microsoft.EntityFrameworkCore;
using agenda.Models;
namespace agenda.Repository;


public class AgendaContext : DbContext, IAgendaContext
{
    // classe com o context de agenda. Essa classe estende de DbContext.
    // public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) {}
    public DbSet<Agenda> Agenda { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // método existente na classe DbContext e sobrescrito na classe Agenda Context. Responsável por realizar a conexão com SqlServer
        if(!optionsBuilder.IsConfigured)
        {
            var connectionString =  "Server=127.0.0.1;Database=Agenda;User=SA;Password=Trybe12345678";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}