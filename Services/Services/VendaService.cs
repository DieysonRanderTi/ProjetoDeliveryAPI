using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Services.Services
{
    public class VendaService : BaseService<Venda>, IVendaService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository) : base(vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }
    }
}
