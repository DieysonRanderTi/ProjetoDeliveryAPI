using Domain.Core.Interfaces.Repositories;
using Domain.Models;
using Infra.Data.Repositories;

namespace Infra.Data.Data.Repositories
{
    public class EstabelecimentoRepository : BaseRepository<Estabelecimento>, IEstabelecimentoRepository
    {
        private readonly Context _context;

        public EstabelecimentoRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}
