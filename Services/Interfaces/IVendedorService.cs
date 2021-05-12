using Services.Models;
using System;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IVendedorService : IDisposable
    {
        Task Adicionar(Vendedor vendedor);
        Task Atualizar(Vendedor vendedor);
        Task Remover(Guid id);
    }
}
