using CinnamOnBooks.Domain.Model.Entities.Leitores;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace CinnamOnBooks.Infra.DataAccess.Repositories
{
    public class LeitorMemDbRepository : ILeitorRepository
    {
        private readonly static List<Leitor> _leitor = new List<Leitor>();

        public bool Atualizar(Leitor entity)
        {
            return true;
        }

        public bool Create(Leitor entity)
        {
            int qtdLeitores = _leitor.Count;
            _leitor.Add(entity);
            if (_leitor.Count > qtdLeitores)
                return true;
            return false;
        }

        public Leitor Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leitor> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Leitor entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
