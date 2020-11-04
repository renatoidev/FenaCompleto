using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class CadastrarEstagiarioModel
    {
        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public Guid SupervisorId { get; set; }
    }
}
