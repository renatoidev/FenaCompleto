using System.Linq;
using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace FenaCompleto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstagiarioController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarEstagiario")]
        public IActionResult CadastrarEstagiario(
            [FromServices] IEstagiario repositorioEstagiario,
            [FromServices] IAnalista repositorioAnalista,
            [FromBody] EstagiarioModel model)
        {
            var supervisor = repositorioAnalista.GetById(model.SupervisorId);

            var tecnico = new Estagiario()
            {
                Nome = model.Nome,
                Cargo = model.Cargo,
                Supervisor = supervisor
            };

            repositorioEstagiario.Add(tecnico);
            repositorioEstagiario.SaveChanges();

            return Ok();
        }


        [HttpGet]
        [Route("listarEstagiario")]
        public IActionResult ListarEstagiarios(
            [FromServices] IEstagiario repositorioEstagiario)
        {
            var listaEstagiario = repositorioEstagiario.GetAll();

            var novaLista = listaEstagiario.Select(x => new EstagiarioModel
            {
                Nome = x.Nome,
                Cargo = x.Cargo,
                SupervisorId = x.SupervisorId,

            }).ToList();

            return Ok(novaLista);
        }
    }
}
