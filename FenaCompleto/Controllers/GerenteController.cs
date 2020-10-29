using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FenaCompleto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenteController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarGerente")]
        public IActionResult CadastrarGerente(
            [FromServices] IGerente repositorio,
            [FromBody] GerenteModel model)
        {
            var gerente = new Gerente()
            {
                Nome = model.Nome,
                Cargo = model.Cargo
            };

            repositorio.Add(gerente);
            repositorio.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("listarGerentes")]
        public IActionResult ListarGerentes([FromServices] IGerente repositorio, [FromServices] IAnalista repositorioAnalistas)
        {
            var listaGerentes = repositorio.GetAll();
            var listaAnalistas = repositorioAnalistas.GetAll();

            var novaLista = listaGerentes.Select(x => new GerenteModel
            {
                Id = x.Id,
                Nome = x.Nome,
                Cargo = x.Cargo,
                Analistas = listaAnalistas.Select(y => new AnalistaModel
                {
                    Nome = y.Nome,
                    Cargo = y.Cargo,
                    SupervisorId = y.SupervisorId
                }).Where(s => s.SupervisorId == x.Id).ToList()
            }).ToList();

            return Ok(novaLista);
        }
    }
}
