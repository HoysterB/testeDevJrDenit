using TesteVagaJr.Core;
using TesteVagaJr.Domain.Entities;

namespace TesteVagaJr.Domain.Repositories;

public interface IEmpresaRepository
{
    void AdicionarFornecedor(Fornecedor fornecedor);
    void AdicionarEmpresa(Empresa empresa);

    Task<IEnumerable<Empresa>> GetAllEmpresasAsync();
    Task<Empresa> GetEmpresaAsync(Guid id);
    Task<Empresa> GetByCnpj(string cnpj);
    Task<IEnumerable<Fornecedor>> GetAllFornecedoresDeUmaEmpresa(Guid empresaId);

    IUnitOfWork UnitOfWork { get; }
}