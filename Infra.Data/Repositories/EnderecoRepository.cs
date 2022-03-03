using Domain.Core.Interfaces.Repositories;
using Domain.Entities;
using Infra.Data.Repositories;

namespace Infra.Data.Data.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly Context _context;

        public EnderecoRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}
