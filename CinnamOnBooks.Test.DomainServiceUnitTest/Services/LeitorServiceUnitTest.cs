using CinnamOnBooks.Domain.Model.Entities.Leitores;
using CinnamOnBooks.Domain.Model.Interfaces.Repositories;
using CinnamOnBooks.Domain.Model.Services;
using CinnamOnBooks.Domain.Model.ValueObjects;
using CinnamOnBooks.Infra.DataAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


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
                //Estado = 1,
                //Email = Email. ("ester.santos@gmail.com")
            };

            //Execucao
            var result = leitorService.CriarLeitor(leitor);

            //Validacao
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LeitorInseridoSemSucesso()
        {
            ILeitorRepository leitorRepository = new LeitorMemDbRepository();
            var leitorService = new LeitorService(leitorRepository);

            var leitor = new Leitor
            {
                Id = Guid.NewGuid(),
                Nome = "Ester Ribeiro dos Santos",
                Apelido = "Ester",
                Sexo = 'F',
                //Estado = 1,
                //Email = "ester.santos@gmail.com"
            };

             var result = leitorService.CriarLeitor(leitor);

             Assert.IsFalse(result);

        }

    }
}
