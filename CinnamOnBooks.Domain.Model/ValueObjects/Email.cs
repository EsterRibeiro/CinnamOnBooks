using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CinnamOnBooks.Domain.Model.ValueObjects
{
    public class Email
    {
        public const int TamanhoMaximoEmail = 254;
        public string EnderecoEmail { get; set; }

        public Email() { }

        public Email(string endereco){ }

        public bool EmailValido(string endereco)
        {
            MailAddress m = new MailAddress(endereco);
            return true;

        }


    }
}
