using Microsoft.AspNetCore.Mvc;

namespace TesteVagaJr.Controllers;

public class EmpresaController : MainController
{

    public async Task<IActionResult> CadastrarEmpresa()
    {
        return Ok();
    }
}