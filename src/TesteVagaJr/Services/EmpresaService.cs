using AutoMapper;
using TesteVagaJr.Domain.Dtos;
using TesteVagaJr.Domain.Repositories;
using TesteVagaJr.Services.Interfaces;

namespace TesteVagaJr.Services;

public class EmpresaService : IEmpresaService
{
    private readonly IEmpresaRepository _empresaRepository;
    private readonly IMapper _mapper;
    public EmpresaService(IEmpresaRepository empresaRepository, IMapper mapper)
    {
        _empresaRepository = empresaRepository;
        _mapper = mapper;
    }

    public Task<EmpresaDto> GetEmpresaAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EmpresaDto>> GetAllEmpresasAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<FornecedorDto>> GetFornecedorAsync(Guid empresaId)
    {
        throw new NotImplementedException();
    }
}