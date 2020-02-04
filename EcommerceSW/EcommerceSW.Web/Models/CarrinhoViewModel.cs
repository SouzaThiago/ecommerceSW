using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSW.Web.Model
{
    public class CarrinhoViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome do Produto")]
        public string NomeProduto { get; set; }

        public decimal PrecoUnitario { get; set; }

        public string PromocaoProduto { get; set; }

        public int QuantidadeProduto { get; set; }


        [DisplayName("Total das compras")]
        public decimal ValorTotal { get; set; }
    }
}
