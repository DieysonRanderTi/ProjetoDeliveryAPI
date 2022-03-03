using Domain.Core.Interfaces.Repositories;
using Domain.Entities;
using Infra.Data.Repositories;

namespace Infra.Data.Data.Repositories
{
    public class FormaPagamentoRepository : BaseRepository<FormaPagamento>, IFormaPagamentoRepository
    {
        private readonly Context _context;

        public FormaPagamentoRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}
