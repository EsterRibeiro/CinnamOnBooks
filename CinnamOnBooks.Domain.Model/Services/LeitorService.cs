using CinnamOnBooks.Domain.Model.Entities.Leitores;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using System;


namespace CinnamOnBooks.Domain.Model.Services
{
    /// <summary>
    /// CRUD do objeto leitor
    /// </summary>
    public class LeitorService
    {
        //Injeção de dependência 
        protected ILeitorRepository _leitorRepository;
        public LeitorService(ILeitorRepository leitorRepository)
        {
            _leitorRepository = leitorRepository;
        }

        /// <summary>
        /// Teste ao criar o leitor, caso o nome seja nulo, o usuário não é criado
        /// </summary>
        /// <param name="leitor"></param>
        /// <returns></returns>
        public bool CriarLeitor(Leitor leitor)
        {
            if (leitor.Nome == null) return false;
            _leitorRepository.Create(leitor);
            return true;
        }

        public bool AlterarLeitor(Leitor leitor)
        {
            _leitorRepository.Update(leitor);
            return true;
        }

        public bool ExcluirLeitor(Guid id)
        {
            _leitorRepository.Delete(id);
            return true;
        }
    }
}
