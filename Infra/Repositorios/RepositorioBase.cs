using Dominio.Entidades;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repositorios
{
    public class RepositorioBase<T> : IRepositorio<T>
        where T : Entity
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<T> DbSet;

        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<T>();
        }

        public void Add(T obj)
        {
            _contexto.Add(obj);
        }

        public int SaveChanges()
        {
            return _contexto.SaveChanges();
        }

        public List<T> GetAll()
        {
            var teste = DbSet.ToList();
            return teste;
        }

        public T GetById(Guid? id)
        {
            return DbSet.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
