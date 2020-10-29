using Dominio.Enums;
using System;

namespace Dominio.Modelos
{
    public class TecnicoModel
    {
        public TecnicoModel()
        {
        }

        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public Guid SupervisorId { get; set; }
    }
}
