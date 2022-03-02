using Domain.Core.Interfaces.Repositories;
using Domain.Models;
using Infra.Data.Repositories;

namespace Infra.Data.Data.Repositories
{
    public class UnidadeMedidaRepository : BaseRepository<UnidadeMedida>, IUnidadeMedidaRepository
    {
        private readonly Context _context;

        public UnidadeMedidaRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}
