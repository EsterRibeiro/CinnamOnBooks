using CinnamOnBooks.Domain.Model.Entities.Leitores;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model.Services
{
    /// <summary>
    /// Essa classe permite a criação, alteração e exclusão de um leitor (usuário) na plataforma
    /// </summary>
    public class LeitorService
    {
        //Injeção de dependência 
        protected ILeitorRepository _leitorRepository;
        public LeitorService(ILeitorRepository leitorRepository)
        {
            _leitorRepository = leitorRepository;
        }

        public bool CriarLeitor(Leitor leitor)
        {
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
