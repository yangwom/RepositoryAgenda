using Microsoft.AspNetCore.Mvc;
using agenda.Models;
using agenda.Repository;

namespace agenda.Controllers
{
    [ApiController]
    [Route("agenda")]

    public class AgendaController : Controller
    {
        private readonly IAgendaRepository _repository;
        public AgendaController(IAgendaRepository repository)
        {
            //recebe a repository com as funções de acesso ao banco
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAgenda()
        {
            // rota referente à api em GET - /agenda - Retorno com Json
            return Ok(_repository.GetAgenda());
        }

        [HttpGet("view")]
        public IActionResult AgendaView()
        {
            // rota referente à view em GET - /agenda/view - Retorno com página web
            IList<Agenda> agendaList = _repository.GetAgenda().ToList();
            ViewBag.agenda = agendaList;
            return View();
        }
    }
}