using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Contextos;

namespace Infra.Repositorios
{
    public class RepositorioAnalista : RepositorioBase<Analista>, IAnalista
    {
        public RepositorioAnalista(Contexto contexto) : base(contexto) { }
    }
}
