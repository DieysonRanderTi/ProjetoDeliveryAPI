using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Venda : Base
    {
        public DateTime DataVenda { get; set; } = DateTime.Now;
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int EstabelecimentoId { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public List<Produto> Produtos { get; set; }
        public bool Entregue { get; set; }
        public decimal Total { get; set; }


    //public static decimal ValorTotalVenda(List<Produto> produtos)
    //{
    //   return produtos.Sum(x => x.ValorTotalProduto());
    //}

    }
}
