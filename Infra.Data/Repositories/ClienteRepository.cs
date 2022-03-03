using Domain.Core.Interfaces.Repositories;
using Domain.Entities;
using Infra.Data.Repositories;

namespace Infra.Data.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly Context _context;

        public ClienteRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}
