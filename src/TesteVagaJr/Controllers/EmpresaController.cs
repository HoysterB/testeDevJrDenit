using System;
using AutoMapper;
using TesteVagaJr.ViewModels;
using TesteVagaJr.Services;
using TesteVagaJr.Utilities;
using TesteVagaJr.Services.Interfaces;
using TesteVagaJr.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using TesteVagaJr.Domain.Dtos;

namespace TesteVagaJr.Controllers;

public class EmpresaController : MainController
{
    private readonly IEmpresaService _empresaService;
    private readonly IMapper _mapper; 

    public EmpresaController(IEmpresaService empresaService, IMapper mapper)
    {
        _empresaService = empresaService;
        _mapper = mapper;
    }

    [HttpPost]
    [Route("/api/v1/empresa/adicionar")]
    public async Task<IActionResult> AdicionarEmpresa([FromBody] AdicionarEmpresaViewModel empresaViewModel)
    {
        try
        {
            var empresaDto = _mapper.Map<EmpresaDto>(empresaViewModel);

            var empresaAdicionar = await _empresaService.AddEmpresaAsync(empresaDto);

            return Ok(new ResultViewModel{
                Message = "Empresa criada com sucesso!",
                Success = true,
                Data = empresaAdicionar
            });
        }
        catch(DomainException ex)
        {
            return BadRequest(Responses.DomainErrorMessage(ex.Message, ex.Errors));
        }
        catch(Exception)
        {
            return StatusCode(500,Responses.ApplicationErrorMessage());
        }
    }
}