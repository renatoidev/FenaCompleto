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
            return Ok(gerente);
        }

        [HttpGet]
        [Route("listarGerentes")]
        public IActionResult ListarGerentes([FromServices] IGerente repositorio)
        {
            var listaGerentes = repositorio.GetAll();

            var novaLista = listaGerentes.Select(x => new Gerente
            {
                Id = x.Id,
                Nome = x.Nome,
                Cargo = x.Cargo,
                Analistas = x.Analistas
            }).ToList();

            return Ok(novaLista);
        }
    }
}
