namespace Domain.Entities
{
    public class Endereco : Base
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string PontoReferencia { get; set; }
    }
}
