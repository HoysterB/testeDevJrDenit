using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using TesteVagaJr.Core;
using TesteVagaJr.Domain.Entities;
using TesteVagaJr.Domain.Repositories;

namespace TesteVagaJr.Infrastructure.Repositories;

public class EmpresaRepository : IEmpresaRepository
{
    private readonly ApplicationDbContext _context;
    public IUnitOfWork UnitOfWork => _context;

    public void AdicionarFornecedor(Fornecedor fornecedor)
    {
        _context.Fornecedores.Add(fornecedor);
    }

    public void AdicionarEmpresa(Empresa empresa)
    {
        _context.Empresas.Add(empresa);
    }

    public async Task<IEnumerable<Empresa>> GetAllEmpresasAsync()
    {
        var empresas = await _context.Empresas.AsNoTracking().ToListAsync();
        return empresas;
    }

    public async Task<Empresa> GetEmpresaAsync(Guid id)
    {
        var empresa = await _context.Empresas.SingleOrDefaultAsync(x => x.Id == id);
        return empresa;
    }

    public async Task<Empresa> GetByCnpj(string cnpj)
    {
        var empresa = await _context.Empresas
                                .Where(x => x.Cnpj == cnpj)
                                .AsNoTracking()
                                .ToListAsync();
        
        return empresa.FirstOrDefault();

    }

    public async Task<IEnumerable<Fornecedor>> GetAllFornecedoresDeUmaEmpresa(Guid empresaId)
    {
        var fornecedores = await _context.Fornecedores.Where(x => x.EmpresaId == empresaId).ToListAsync();
        return fornecedores;
    }


}