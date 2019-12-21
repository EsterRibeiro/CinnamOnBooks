using CinnamOnBooks.Domain.Model.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Test.DomainServiceUnitTest.ValueObjects
{
    [TestClass]
    public class EmailUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmailIVazio()
        {
            var endereco = new Email("");
        }
        public void EmailNulo()
        {
            var endereco = new Email(null);
        }

        public void EmailInvalido()
        {
            var endereco = new Email("shdbschbcadbkbcc");
        }

        public void EmailLimiteUltrapassado()
        {
            var endereco = "ester.santos@gmail.com";

            while (endereco.Length < Email.TamanhoMaximoEmail + 1)
            {
                endereco = endereco + "ester.santos@gmail.com";
            }

            new Email(endereco);
        }

        public void EmailValido()
        {
            var endereco = "ester.santos@gmail.com";
            var email = new Email(endereco);

            Assert.AreEqual(endereco, email.Endereco);
        }
    }
}
