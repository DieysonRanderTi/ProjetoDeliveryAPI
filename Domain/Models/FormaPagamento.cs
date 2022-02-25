namespace Domain.Models
{
    public class FormaPagamento : Base
    {
        public bool LevarMaquinaCartao { get; set; } = false;
        public bool LevarTroco { get; set; } = false;
        public decimal TrocoPara { get; set; }

    }
}
