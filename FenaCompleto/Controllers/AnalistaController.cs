using System.Linq;
using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace FenaCompleto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalistaController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarAnalista")]
        public IActionResult CadastrarAnalista(
            [FromServices] IAnalista repositorioAnalistas,
            [FromServices] IGerente repositorioGerentes,
            [FromBody] AnalistaModel model)
        {
            var supervisor = repositorioGerentes.GetById(model.SupervisorId);

            var analista = new Analista()
            {
                Nome = model.Nome,
                Cargo = model.Cargo,
                Supervisor = supervisor
            };

            repositorioAnalistas.Add(analista);
            repositorioAnalistas.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("listarAnalistas")]
        public IActionResult ListarAnalistas(
            [FromServices] IAnalista repositorio,
            [FromServices] ITecnico repositorioTecnico,
            [FromServices] IEstagiario repositorioEstagiario)
        {
            var listaAnalista = repositorio.GetAll();
            var listaTecnico = repositorioTecnico.GetAll();
            var listaEstagiario = repositorioEstagiario.GetAll();

            var novaLista = listaAnalista.Select(x => new AnalistaModel
            {
                Nome = x.Nome,
                Cargo = x.Cargo,
                SupervisorId = x.SupervisorId,
                Tecnicos = listaTecnico.Select(y => new Tecnico
                {
                    Nome = y.Nome,
                    Cargo = y.Cargo,
                    SupervisorId = y.SupervisorId
                }).Where(s => s.SupervisorId == x.Id).ToList(),
                Estagiarios = listaEstagiario.Select(y => new Estagiario
                {
                    Nome = y.Nome,
                    Cargo = y.Cargo,
                    SupervisorId = y.SupervisorId
                }).Where(s => s.SupervisorId == x.Id).ToList(),

            }).ToList();

            return Ok(novaLista);
        }
    }
}
