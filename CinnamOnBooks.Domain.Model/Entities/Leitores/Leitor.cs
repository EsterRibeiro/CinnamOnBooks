using CinnamOnBooks.Domain.Model.Enums;
using CinnamOnBooks.Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model.Entities.Leitores
{
    public class Leitor
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public char Sexo { get; set; }
        public EEstado Estado { get; set; }
        public Email Email { get; set; }
        public List<Favorito> LivrosFavoritos { get; set; }
        public List<Avaliado> LivrosAvaliados { get; set; }
    }
}
