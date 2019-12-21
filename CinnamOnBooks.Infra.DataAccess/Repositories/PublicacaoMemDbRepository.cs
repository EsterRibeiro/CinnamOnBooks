using CinnamOnBooks.Domain.Model;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace CinnamOnBooks.Infra.DataAccess
{
    public class PublicacaoRepository: IPublicacaoRepository
    {
        public bool Create(Publicacao entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Publicacao Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Publicacao> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Publicacao entity)
        {
            throw new NotImplementedException();
        }
    }
}
