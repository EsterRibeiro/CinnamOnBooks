using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model.Services
{
    /// <summary>
    /// Esse servico pode criar ou excluir a publicacao de um lancamento de livro na plataforma.
    /// </summary>
    public class PublicacaoService
    {

        //Injeção de dependência 
        protected IPublicacaoRepository _publicacaoRepository;
        public PublicacaoService(IPublicacaoRepository publicacaoRepository)
        {
            _publicacaoRepository = publicacaoRepository;
        }

        public bool CriarPublicacao(Publicacao publicacao)
        {
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
