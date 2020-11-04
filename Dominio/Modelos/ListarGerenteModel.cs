using Dominio.Enums;
using System;
using System.Collections.Generic;

namespace Dominio.Modelos
{
    public class ListarGerenteModel
    {
        public ListarGerenteModel() { }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ECargo Cargo { get; set; } = ECargo.Gerente;
        public List<ListarAnalistaModel> Analistas { get; set; } = new List<ListarAnalistaModel>();

    }
}
