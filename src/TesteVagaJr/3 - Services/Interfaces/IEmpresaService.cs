using TesteVagaJr.Services.Dtos;

namespace TesteVagaJr.Services.Interfaces;

public interface IEmpresaService
{
    Task<EmpresaDto>AddEmpresaAsync(EmpresaDto empresaDTO);
    Task<EmpresaDto> GetEmpresaAsync(Guid empresaId);
    Task<IEnumerable<EmpresaDto>> GetAllEmpresasAsync();
    Task<IEnumerable<FornecedorDto>> GetFornecedorAsync(Guid empresaId);

}