using Dominio.Enums;
using System;

namespace Dominio.Modelos
{
    public class ListarTecnicoModel
    {
        public ListarTecnicoModel()
        {
        }

        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public Guid SupervisorId { get; set; }
    }
}
