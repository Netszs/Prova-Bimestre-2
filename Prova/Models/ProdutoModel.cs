using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Prova.Models
{
    public class ProdutoModel
    {
        [Key]
        [Display(Name = "Id: ")]
        public long IdProduto { get; set; }

        [Required(ErrorMessage = "Digite o nome do produto a seguir: ")]
        [Display(Name = "Nome: ")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Digite o descrição a seguir: ")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        public virtual ICollection<FornecedorModel> Fornecedores { get; set; }
    }
}