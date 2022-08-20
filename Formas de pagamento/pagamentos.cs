using System;
using System.Collections.Generic;
using System.Text;

namespace Formas_de_pagamento
{
    public class Pagamentos
    {
        public string nomeproduto { get; set; }

        public decimal valorProduto { get; set; }

        public int codigo { get; set; }

        public decimal desconto { get; set; }

        public decimal parcela { get; set; }

        public decimal juros { get; set; }

        public decimal taxa { get; set; }

        public string avista()
        {
            desconto = (valorProduto * taxa) / 100;
            valorProduto = valorProduto - desconto;
            return $"Você recebeu um desconto de {taxa}% por pagar à vista \no desconto reduziu {desconto} reais\no valor a ser pago é de {valorProduto} Reais";
        }
        public string cartao()
        {
            desconto = (valorProduto * taxa) / 100;
            valorProduto = valorProduto - desconto;
            return $"Você recebeu um desconto de {taxa}% por pagar no cartão \no desconto reduziu {desconto} Reais\no valor a ser pago é de {valorProduto} Reais";
        }
        public string parcelax2()
        {
            parcela = valorProduto / 2;
            return $"O valor total a ser pago é de {valorProduto} Reais\n Sendo parcelado em 2 vezes de {Math.Round(parcela, 2)} Reais";
        }
        public string parcelax3()
        {
            parcela = valorProduto / 3;
            desconto = (valorProduto * 10) / 100;
            juros = valorProduto + desconto;
            return $"O valor total a ser pago é de {juros} Reais\n Sendo parcelado em 3 vezes de R$ {Math.Round(parcela,2)}\n Foram adicionados {desconto} Reais de juros devido ao parcelamento de 3x. ";
        }
    }
}
