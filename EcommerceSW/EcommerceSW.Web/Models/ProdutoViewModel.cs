using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSW.Web.Model
{
    public class ProdutoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do produto")]
        [DisplayName("Nome do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o preço do produto")]
        [DisplayName("Preço")]
        public decimal Preco { get; set; }

        [DisplayName("Promoção")]
        
        public string Promocao { get; set; }


        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "Digite a quantidade")]
        [Range(1, 999)]
        public int Quantidade { get; set; }
    }
}
