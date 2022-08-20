using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace testeclass
{
    class Cadastro
    {
        public string nome { get; set; }

        public string marca { get; set; }

        public decimal valor { get; set; }

        public decimal desconto { get; set; }

        public string teste()
        {
            this.desconto = (valor * 3) / 100;
            this.valor = this.valor - desconto;
            return $"Seu produto foi : {nome}, da marca {marca}.\nO desconto foi de {desconto} e o valor pago foi de {valor}.";
        }
    }
}
