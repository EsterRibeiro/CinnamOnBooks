using CinnamOnBooks.Domain.Model.Entities.Leitores;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using CinnamOnBooks.Domain.Model.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CinnamOnBooks.Infra.DataAccess.Repositories;
using System;
using CinnamOnBooks.Domain.Model.Enums;
using CinnamOnBooks.Domain.Model.ValueObjects;

namespace CinnamOnBooks.Test.DomainServiceUnitTest.Services
{
    /// <summary>
    /// Classe de teste da criacao do leitor
    /// </summary>
    [TestClass]
    public class LeitorServiceUnitTest
    {
        //preparacao

        [TestMethod]
        public void LeitorInseridoComSucesso()
        {
            ILeitorRepository leitorRepository = new LeitorMemDbRepository();
            var leitorService = new LeitorService(leitorRepository);
            var leitor = new Leitor
            {
                Id = Guid.NewGuid(),
                Nome = "Ester Ribeiro dos Santos",
                Apelido = "Ester",
                Sexo = 'F',
                Estado = EEstado.RioDeJaneiro,
                Email = new Email("ester.santos@gmail.com")
            };

            //Execucao
            var result = leitorService.CriarLeitor(leitor);

            //Validacao
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeitorInseridoSemSucesso()
        {
            ILeitorRepository leitorRepository = new LeitorMemDbRepository();
            var leitorService = new LeitorService(leitorRepository);

            var leitor = new Leitor
            {
                Id = Guid.NewGuid(),
                Apelido = "Ester",
                Sexo = 'F',
                Estado = EEstado.RioDeJaneiro,
                Email = new Email("ester.santos@gmail.com")
            };

             var result = leitorService.CriarLeitor(leitor);

             Assert.IsFalse(result);

        }

    }
}
