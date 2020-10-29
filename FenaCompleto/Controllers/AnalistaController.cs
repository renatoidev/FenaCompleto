using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Enums;
using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Http;
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
            [FromServices] IAnalista repositorio,
            [FromServices] IGerente repositorioGerente,
            [FromBody] AnalistaModel model)
        {
            var supervisor = repositorioGerente.GetById(model.SupervisorId);

            var analista = new Analista()
            {
                Nome = model.Nome,
                Cargo = model.Cargo,
                Supervisor = supervisor
            };

            supervisor.Analistas.Add(analista);

            repositorio.Add(analista);
            repositorio.SaveChanges();
            return Ok(analista);
        }

        [HttpGet]
        [Route("listarAnalistas")]
        public IActionResult ListarAnalistas(
            [FromServices] IAnalista repositorio)
        {
            var listaAnalista = repositorio.GetAll();

            var novaLista = listaAnalista.Select(x => new Analista
            {
                Nome = x.Nome,
                Cargo = x.Cargo,
                SupervisorId = x.SupervisorId,
                Estagiarios = x.Estagiarios,
                Tecnicos = x.Tecnicos
            }).ToList();

            return Ok(novaLista);
        }
    }
}
