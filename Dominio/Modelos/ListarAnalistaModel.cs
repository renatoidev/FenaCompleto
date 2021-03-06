﻿using Dominio.Entidades;
using Dominio.Enums;
using System;
using System.Collections.Generic;

namespace Dominio.Modelos
{
    public class ListarAnalistaModel
    {
        public ListarAnalistaModel() { }

        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public Guid SupervisorId { get; set; }
        public List<Tecnico> Tecnicos { get; set; } = new List<Tecnico>();
        public List<Estagiario> Estagiarios { get; set; } = new List<Estagiario>();

    }
}
