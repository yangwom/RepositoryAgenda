using agenda.Models;

namespace agenda.Repository
{
    // classe referente ao repository. Possui as funções do db e recebe o context com a conexão do banco de dados.
    public class AgendaRepository : IAgendaRepository
    {
        protected readonly AgendaContext _context;

        public AgendaRepository(AgendaContext context)
        {
            // Ao construir a classe repository, recebe o context de conexão com o Db
            _context = context;
        }

        public IEnumerable<Agenda> GetAgenda()
        {
            // método que retorna todos os dados de Agenda
            return _context.Agenda;
        }
    }
}