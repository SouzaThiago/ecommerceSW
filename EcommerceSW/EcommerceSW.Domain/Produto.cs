using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceSW.Domain
{
    [Table("Produto")]
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Promocao { get; set; }
    }
}
