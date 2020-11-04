using Dominio.Enums;
using System;

namespace Dominio.Modelos
{
    public class ListarEstagiarioModel
    {
        public ListarEstagiarioModel()
        {
        }

        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public Guid SupervisorId { get; set; }
    }
}