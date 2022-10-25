using agenda.Models;

namespace agenda.Repository
{
    public interface IAgendaRepository
    {
        IEnumerable<Agenda> GetAgenda();
    }
}