using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Services.Services
{
    public class UnidadeMedidaService : BaseService<UnidadeMedida>, IUnidadeMedidaService
    {
        private readonly IUnidadeMedidaRepository _unidadeMedidaRepository;

        public UnidadeMedidaService(IUnidadeMedidaRepository unidadeMedidaRepository) : base(unidadeMedidaRepository)
        {
            _unidadeMedidaRepository = unidadeMedidaRepository;
        }
    }
}
