using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RisoOdonto.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {

        [Key]
        public int IdFuncionario { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        [Required]
        [MaxLength(150)]
        public string Cargo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login_Funcionario { get; set; }
        [Required]
        [MaxLength(6)]
        public string Senha { get; set; }


        //chave estrangeira
        [ForeignKey("TipoUsuario")]
        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario? TipoUsuario { get; set; }
    }
}
