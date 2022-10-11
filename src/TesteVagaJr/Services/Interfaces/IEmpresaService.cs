using TesteVagaJr.Domain.Dtos;

namespace TesteVagaJr.Services.Interfaces;

public interface IEmpresaService
{
    Task<EmpresaDto> GetEmpresaAsync();
    Task<IEnumerable<EmpresaDto>> GetAllEmpresasAsync();
    Task<IEnumerable<FornecedorDto>> GetFornecedorAsync(Guid empresaId);

}