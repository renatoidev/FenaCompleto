using Dominio.Enums;
using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Analista : Entity
    {
        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public List<Tecnico> Tecnicos { get; set; } = new List<Tecnico>();
        public List<Estagiario> Estagiarios { get; set; } = new List<Estagiario>();
        public Gerente Supervisor { get; set; }
        public Guid SupervisorId { get; set; }
    }
}