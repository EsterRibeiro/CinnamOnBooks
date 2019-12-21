using CinnamOnBooks.Domain.Model;
using CinnamOnBooks.Domain.Model.Entities;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using CinnamOnBooks.Domain.Model.Services;
using CinnamOnBooks.Infra.DataAccess;
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
                Autor = new Autor { Nome = "Waldir Santos" },
                Conteudo = "Que dia lindo para ler \"Flôr de Sangue\""
            };

            var result = publicacaoService.CriarPublicacao(publicacao);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PublicacaoSemSucesso()
        {
            IPublicacaoRepository publicacaoRepository = new PublicacaoMemDbRepository();
            var publicacaoService = new PublicacaoService(publicacaoRepository);
            var publicacao = new Publicacao
            {
                Id = Guid.NewGuid(),
                Conteudo = "Que dia lindo para ler \"Flôr de Sangue\""
            };

            var result = publicacaoService.CriarPublicacao(publicacao);

            Assert.IsFalse(result);
        }


    }
}
