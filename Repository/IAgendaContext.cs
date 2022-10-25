using Microsoft.EntityFrameworkCore;
using agenda.Models;
namespace agenda.Repository
{
    public interface IAgendaContext
    {
        public DbSet<Agenda> Agenda { get; set; }
        public int SaveChanges();
    }
}