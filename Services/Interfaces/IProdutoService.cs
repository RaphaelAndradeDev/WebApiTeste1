using Services.Models;
using System;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produtos produtos);
        Task Atualizar(Produtos produtos);
        Task Remover(Guid id);
    }
}
