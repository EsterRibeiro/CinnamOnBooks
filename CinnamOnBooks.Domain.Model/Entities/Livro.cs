using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model.Entities
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Edicao { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
    }
}
