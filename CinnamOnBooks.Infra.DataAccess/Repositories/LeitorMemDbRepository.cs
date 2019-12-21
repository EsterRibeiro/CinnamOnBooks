using CinnamOnBooks.Domain.Model.Entities.Leitores;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace CinnamOnBooks.Infra.DataAccess.Repositories
{
    public class LeitorRepository: ILeitorRepository
    {

        public bool Atualizar(Leitor entity)
        {
            return true;
        }

        public bool Create(Leitor entity)
        {
            throw new NotImplementedException();
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
