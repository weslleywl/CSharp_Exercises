using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace testeclass
{
    class Virtual : Cadastro
    {
        public string cpf { get; set; }

        public string email { get; set; }


        public string online()
        {
            return $"seu cpf é {cpf}\nSeu email é {email}\nE seu produto foi : {nome} da marca : {marca}.";
        }
    }
}
