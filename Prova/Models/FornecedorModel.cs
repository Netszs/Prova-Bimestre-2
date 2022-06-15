using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Prova.Models
{
    public class FornecedorModel
    {
        [Key]
        [Display(Name = "Id: ")]
        public long IdFornecedor { get; set; }

        [Required(ErrorMessage = "Digite o nome a seguir: ")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Digite o email a seguir: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o logradouro a seguir: ")]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Digite o número a seguir: ")]
        [Display(Name = "Número: ")]
        public string Numero { get; set; }

        [Display(Name = "Complemento: ")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Digite o bairro a seguir: ")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Digite a cidade a seguir: ")]
        [Display(Name = "Cidade")]
        public string Cidade{ get; set; }

        public ProdutoModel Produto { get; set; }
    }
}