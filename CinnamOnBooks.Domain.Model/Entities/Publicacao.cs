using CinnamOnBooks.Domain.Model.Entities;
using System;


namespace CinnamOnBooks.Domain.Model
{
    public class Publicacao
    {
        public Guid Id { get; set; }
        public Autor Autor { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Conteudo { get; set; }
    }
}
