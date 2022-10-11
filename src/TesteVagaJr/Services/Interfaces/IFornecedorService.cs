using TesteVagaJr.Domain.Entities;

namespace TesteVagaJr.Services.Interfaces
{
    public interface IFornecedorService
    {
        Task<Fornecedor> AdicionarFornecedor(Fornecedor fornecedor);
        
    }
}