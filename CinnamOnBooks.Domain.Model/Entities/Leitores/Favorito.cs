using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model.Entities.Leitores
{
    public class Favorito
    {
        public Guid ExternalId { get; set; }
        public string ExternalNomeLivro { get; set; }
        public bool Favoritado { get; set; }
    }
}
