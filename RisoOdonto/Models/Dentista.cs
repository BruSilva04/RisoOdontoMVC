using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RisoOdonto.Models
{
    [Table("Dentista")]
    public class Dentista
    {

        [Key]
        public int IdDentista { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login_Dentista { get; set; }
        [Required]
        [MaxLength(6)]
        public string Senha { get; set; }
        [Required]
        public int Especialidade { get; set; }
    }
}
