using System.Linq;
using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace FenaCompleto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnicoController : ControllerBase
    {

        [HttpPost]
        [Route("cadastrarTecnico")]
        public IActionResult CadastrarTecnico(
            [FromServices] ITecnico repositorioTecnico,
            [FromServices] IAnalista repositorioAnalista,
            [FromBody] CadastrarTecnicoModel model)
        {
            var supervisor = repositorioAnalista.GetById(model.SupervisorId);

            var tecnico = new Tecnico()
            {
                Nome = model.Nome,
                Cargo = model.Cargo,
                Supervisor = supervisor
            };

            repositorioTecnico.Add(tecnico);
            repositorioTecnico.SaveChanges();
            
            return Ok();
        }


        [HttpGet]
        [Route("listarTecnicos")]
        public IActionResult ListarTecnicos(
            [FromServices] ITecnico repositorioTecnico)
        {
            var listaTecnico = repositorioTecnico.GetAll();

            var novaLista = listaTecnico.Select(x => new ListarTecnicoModel
            {
                Nome = x.Nome,
                Cargo = x.Cargo,
                SupervisorId = x.SupervisorId,

            }).ToList();

            return Ok(novaLista);
        }
    }
}
