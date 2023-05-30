using System.ComponentModel.DataAnnotations;

namespace DockerKubernetesPersonal.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o produto")]
        [StringLength(150, MinimumLength = 4)]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O preço de custo do produto é obrigatório")]
        [Display(Name = "Informe o preço de custo do produto")]
        public decimal Preco { get; set; }
        
        [Display(Name = "Informe o produto")]
        [StringLength(1000, MinimumLength = 4)]
        public string? Descricao{ get; set; }
        public int Quantidade { get; set; } = 0;
    }
}
