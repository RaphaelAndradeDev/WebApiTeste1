using Services.Interfaces;
using Services.Models;
using System;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;


        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produtos produtos)
        {
            await _produtoRepository.Adicionar(produtos);
        }

        public async Task Atualizar(Produtos produtos)
        {
            await _produtoRepository.Atualizar(produtos);
        }      

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
