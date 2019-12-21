using CinnamOnBooks.Domain.Model;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace CinnamOnBooks.Infra.DataAccess
{
    public class PublicacaoMemDbRepository : IPublicacaoRepository
    {
        private readonly static List<Publicacao> _publicacao = new List<Publicacao>();


        /// <summary>
        /// Validacao da publicacao
        /// </summary>
        /// <param name="publicacao"></param>
        /// <returns></returns>
        public bool Create(Publicacao publicacao)
        {
            int qtdPublicacao = _publicacao.Count;
            _publicacao.Add(publicacao);

            if (_publicacao.Count > qtdPublicacao)
                return true;
        
            return false;
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
