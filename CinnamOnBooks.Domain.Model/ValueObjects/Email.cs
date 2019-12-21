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
        public string Endereco { get; set; }

        public Email(string endereco)
        {
            
        }

        public bool EmailValido(string endereco)
        {    
            MailAddress isValidMail = new MailAddress("ester.santos@gmail.com");
            return true;

        }


    }
}
