using CinnamOnBooks.Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model.Entities.Leitores
{
    public class Avaliado
    {
        public Guid ExternalId { get; set; }
        public string ExternalNomeLivro { get; set; }
        public EAvaliacao AvaliacaoLivro { get; set; }
    }
}
