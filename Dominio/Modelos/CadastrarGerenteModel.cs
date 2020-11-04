using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class CadastrarGerenteModel
    {
        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
    }
}
