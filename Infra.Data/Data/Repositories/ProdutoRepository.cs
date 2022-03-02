using Domain.Core.Interfaces.Repositories;
using Domain.Models;
using Infra.Data.Repositories;

namespace Infra.Data.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly Context _context;

        public ProdutoRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}
