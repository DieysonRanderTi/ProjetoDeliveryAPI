using Domain.Core.Interfaces.Repositories;
using Domain.Entities;
using Infra.Data.Repositories;

namespace Infra.Data.Data.Repositories
{
    public class VendaRepository : BaseRepository<Venda>, IVendaRepository
    {
        private readonly Context _context;

        public VendaRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}
