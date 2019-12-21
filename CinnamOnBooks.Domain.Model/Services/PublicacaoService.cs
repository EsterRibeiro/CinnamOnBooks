using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model.Services
{
    /// <summary>
    ///CRUD do serviço de lançamento de publicações do autor na plataforma
    /// </summary>
    public class PublicacaoService
    {

        //Injeção de dependência 
        protected IPublicacaoRepository _publicacaoRepository;
        public PublicacaoService(IPublicacaoRepository publicacaoRepository)
        {
            _publicacaoRepository = publicacaoRepository;
        }

        /// <summary>
        /// Autenticação na criação de uma publicação do autor, no caso de publicacoes sem autor
        /// ou com a data de publicacao maior que a atual
        /// </summary>
        /// <param name="publicacao"></param>
        /// <returns></returns>
        public bool CriarPublicacao(Publicacao publicacao)
        {
            if (publicacao.Autor == null)
                return false;

            if (publicacao.DataPublicacao > DateTime.Now)
                return false;

            _publicacaoRepository.Create(publicacao);
            return true;
        }

        public bool ExcluirPublicacao(Guid id)
        {
            _publicacaoRepository.Delete(id);
            return true;
        }
    }
}
