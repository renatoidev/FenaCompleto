﻿using Dominio.Enums;
using System;

namespace Dominio.Entidades
{
    public class Estagiario : Entity
    {
        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public Analista Supervisor { get; set; }
        public Guid SupervisorId { get; set; }
    }
}