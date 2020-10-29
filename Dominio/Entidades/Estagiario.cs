using Dominio.Enums;

namespace Dominio.Entidades
{
    public class Estagiario : Entity
    {
        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public Analista Supervisor { get; set; }
    }
}