using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceSW.Domain
{
    [Table("Carrinho")]
    public class Carrinho
    {
        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public decimal PrecoUnitario { get; set; }

        public string PromocaoProduto { get; set; }

        public int QuantidadeProduto { get; set; }

        public decimal ValorTotal { get; set; }
    }
}
