﻿using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Models;

namespace Domain.Services.Services
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
