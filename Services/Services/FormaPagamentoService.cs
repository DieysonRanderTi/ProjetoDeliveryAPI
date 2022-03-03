using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Services.Services
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
