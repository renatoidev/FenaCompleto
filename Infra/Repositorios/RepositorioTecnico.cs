using Dominio.Entidades;
using Dominio.Interfaces;
using Infra.Contextos;

namespace Infra.Repositorios
{
    public class RepositorioTecnico : RepositorioBase<Tecnico>, ITecnico
    {
        public RepositorioTecnico(Contexto contexto) : base(contexto) { }
    }
}
