using Dominio.Enums;
using System;
using System.Collections.Generic;

namespace Dominio.Modelos
{
    public class GerenteModel
    {
        public GerenteModel() { }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ECargo Cargo { get; set; } = ECargo.Gerente;
        public List<AnalistaModel> Analistas { get; set; } = new List<AnalistaModel>();

    }
}
