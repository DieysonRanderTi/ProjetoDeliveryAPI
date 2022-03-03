using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Services.Services
{
    public class EstabelecimentoService : BaseService<Estabelecimento>, IEstabelecimentoService
    {
        private readonly IEstabelecimentoRepository _estabelecimentoRepository;

        public EstabelecimentoService(IEstabelecimentoRepository estabelecimentoRepository) : base(estabelecimentoRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
        }
    }
}
