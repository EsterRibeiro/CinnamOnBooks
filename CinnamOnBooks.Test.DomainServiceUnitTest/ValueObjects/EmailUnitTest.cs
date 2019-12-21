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
        public void EmailIVazio()
        {
            var endereco = new Email("");
        }

        [TestMethod]
        public void EmailNulo()
        {
            var endereco = new Email(null);
        }

        [TestMethod]
        public void EmailInvalido()
        {
            var endereco = new Email("shdbschbcadbkbcc");
        }

        [TestMethod]
        public void EmailLimiteUltrapassado()
        {
            var endereco = "ester.santos@gmail.com";

            while (endereco.Length < Email.TamanhoMaximoEmail + 1)
            {
                endereco = endereco + "ester.santos@gmail.com";
            }

            new Email(endereco);
        }

        [TestMethod]
        public void EmailValido()
        {
            var endereco = "ester.santos@gmail.com";
            var email = new Email(endereco);
        }
    }
}
