using Domain.Core.Interfaces.Repositorys;
using Domain.Core.Interfaces.Services;
using Domain.Models;

namespace Domain.Services.Services
{
    public class FormaPagamentoService : BaseService<FormaPagamento>, IFormaPagamentoService
    {
        private readonly IFormaPagamentoRepository _formaPagamentoRepository;

        public FormaPagamentoService(IFormaPagamentoRepository formaPagamentoRepository) : base(formaPagamentoRepository)
        {
            _formaPagamentoRepository = formaPagamentoRepository;
        }
    }
}
