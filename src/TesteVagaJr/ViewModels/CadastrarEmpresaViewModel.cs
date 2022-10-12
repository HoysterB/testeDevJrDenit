using System.ComponentModel.DataAnnotations;

namespace TesteVagaJr.ViewModels
{

    public class CadastrarEmpresaViewModel
    {
         [Required(ErrorMessage = "A uf não pode ser vazia.")]
         [MinLength(2, ErrorMessage = "A uf deve ter no mínimo 2 caracteres.")]
         [MaxLength(2,ErrorMessage = "A uf deve ter no máximo 2 carateres.")]
         public string Uf { get;  set; }

         [Required(ErrorMessage = "O nome fantasia não pode ser vazio.")]
         [MinLength(40, ErrorMessage = "O nome fantasia deve ter no mínimo 40 caracteres")]
         [MaxLength(100, ErrorMessage = "O nome fantasia deve ter no máximo 100 caracteres")]
         public string NomeFantasia { get;  set; }
         

         [Required(ErrorMessage = "O cnpj não pode ser vazio.")]
         [MinLength(11, ErrorMessage = "O cnpj deve ter no mínimo 11 caracteres.")]
         [MaxLength(11, ErrorMessage = "O cnpj deve ter no máximo 11 carateres.")]
         public string Cnpj { get;  set; }
    }

}

