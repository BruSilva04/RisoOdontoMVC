using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RisoOdonto.Models
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {

        [Key]
        public int IdTipoUsuario { get; set; }
        [MaxLength(150)]
        [Required]
        public string DescricaoTipoUsuario { get; set; }

    }
}
