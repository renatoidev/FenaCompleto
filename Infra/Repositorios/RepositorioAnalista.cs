using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.Modelos;
using Infra.Contextos;
using Infra.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Infra.Repositorios
{
    public class RepositorioAnalista : RepositorioBase<Analista>, IAnalista
    {
        public RepositorioAnalista(Contexto contexto) : base(contexto) {
        }

    }
}
