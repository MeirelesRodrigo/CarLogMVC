using System.ComponentModel.DataAnnotations;

namespace AppCarLog.Models
{
    public class Veiculos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(7, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório ")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} éstá em formato incorreto")]
        [Display(Name = "Ano de fabricação")]
        public DateTime AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Km { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, MinimumLength =2, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string Base {  get; set; }

        public bool Status {  get; set; }
    }
}
