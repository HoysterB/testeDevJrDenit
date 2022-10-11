using System.ComponentModel.DataAnnotations;

namespace TesteVagaJr.ViewModels;

public class AdicionarEmpresaViewModel
{
    [Required(ErrorMessage = "A uf não pode ser vazia.")]
    [MinLength(2, ErrorMessage = "A uf deve ter no mínimo 2 caracteres.")]
    [MaxLength(2,ErrorMessage = "A uf deve ter no máximo 2 carateres.")]
    public string Uf { get; private set; }
    [Required]
    public string NomeFantasia { get; private set; }
    public string Cnpj { get; private set; }
}