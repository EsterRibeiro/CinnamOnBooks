using CinnamOnBooks.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model
{
    public class Publicacao
    {
        public Guid Id { get; set; }
        public Livro TituloLivro { get; set; }
        public Livro EdicaoLivro { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
    }
}
