namespace Domain.Entities
{
    public class Produto : Base
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public string Foto { get; set; }
        public decimal Quantidade { get; set; }
        public int UnidadeMedidaId { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        //public decimal ValorTotalProduto()
        //{
        //    return Valor * Quantidade;
        //}
    }
}
