using CinnamOnBooks.Domain.Model;
using CinnamOnBooks.Domain.Model.Entities;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using CinnamOnBooks.Domain.Model.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CinnamOnBooks.Test.DomainServiceUnitTest.Services
{
    /// <summary>
    /// Classe de teste da publicacao
    /// </summary>
    [TestClass]
    public class PublicacaoServiceUnitTest
    {
        [TestMethod]
        public void PublicacaoComSucesso()
        {
            IPublicacaoRepository publicacaoRepository = new PublicacaoMemDbRepository();
            var publicacaoService = new PublicacaoService(publicacaoRepository);
            var publicacao = new Publicacao
            {
                Id = Guid.NewGuid(),
                Livro.TituloLivro = "Flor de sangue",
                EdicaoLivro = "1°",
                Autor = "Waldir Santos",
                Editora = "Flor"
            };

            var result = publicacaoService.CriarPublicacao(publicacao);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PublicacaoSemSucesso()
        {
            IPublicacaoRepository publicacaoRepository = new PublicacaoMemDbRepository();
            var publicacaoService = new PublicacaoService(publicacaoRepository);
            var publicacao = new Publicacao
            {
                Id = Guid.NewGuid(),
                TituloLivro = "Flor de sangue",
                EdicaoLivro = "1°",
                Autor = "Waldir Santos",
                Editora = "Flor"
            };

            var result = publicacaoService.CriarPublicacao(publicacao);

            Assert.IsFase(result);
        }


    }
}
