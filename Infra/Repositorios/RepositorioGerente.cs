using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Contextos;

namespace Infra.Repositorios
{
    public class RepositorioGerente : RepositorioBase<Gerente>, IGerente
    {
        public RepositorioGerente(Contexto contexto) : base (contexto) { }
    }
}
