using Dominio.Enums;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Gerente : Entity
    {
        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
        public List<Analista> Analistas { get; set; } = new List<Analista>();
    }
}
