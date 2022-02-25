using System.Collections.Generic;

namespace Domain.Models
{
    public class Estabelecimento : Base
    {
        public string NomeFantasia { get; set; }
        public bool Disponivel { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
