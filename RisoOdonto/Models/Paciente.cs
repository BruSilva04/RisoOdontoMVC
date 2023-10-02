using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RisoOdonto.Models
{
    [Table("Paciente")]
    public class Paciente
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Telefone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        [Required]
        [MaxLength(150)]
        public string CPF { get; set; }
        [Required]
        [MaxLength(150)]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(150)]
        public string Endereco { get; set; }
        [Required]
        [MaxLength(6)]
        public string Senha { get; set; }



        //chave estrangeira
        [ForeignKey("TipoUsuario")]
        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario? TipoUsuario { get; set; }      
    }
}
