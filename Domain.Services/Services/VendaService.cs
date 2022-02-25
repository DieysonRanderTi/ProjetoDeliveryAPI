using Domain.Core.Interfaces.Repositorys;
using Domain.Core.Interfaces.Services;
using Domain.Models;

namespace Domain.Services.Services
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
