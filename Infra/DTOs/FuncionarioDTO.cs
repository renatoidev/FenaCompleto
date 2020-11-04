using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs
{
    public class FuncionarioDTO
    {
        public List<Analista> Analistas { get; set; }
        public List<Estagiario> Estagiarios { get; set; }
        public List<Gerente> Gerentes { get; set; }
        public List<Tecnico> Tecnicos { get; set; }
    }
}
