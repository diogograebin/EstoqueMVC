using System.ComponentModel.DataAnnotations;

namespace EstoqueMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A quantidade do produto é obrigatória.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        public decimal Preco { get; set; }
    }
}
