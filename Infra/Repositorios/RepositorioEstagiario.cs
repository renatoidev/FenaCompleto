using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Contextos;

namespace Infra.Repositorios
{
    public class RepositorioEstagiario : RepositorioBase<Estagiario>, IEstagiario
    {
        public RepositorioEstagiario(Contexto contexto) : base(contexto) { }
    }
}
