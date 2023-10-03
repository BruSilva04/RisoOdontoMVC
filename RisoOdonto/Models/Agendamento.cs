using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using NuGet.Packaging.Signing;
using System.Timers;
using System.Runtime.CompilerServices;

namespace RisoOdonto.Models
{
    [Table("Agendamento")]
    public class Agendamento
    {

            [Key]
            public int IdAgendamento { get; set; }
            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime Data_Consulta { get; set; }
            [Required]
            //[DateTimeConstant]
            public DateOnly Horario { get; set; }
            [Required]
            public bool Primeira_Consulta { get; set; }           
            [Required]
            [MaxLength(150)]
            public string Status_Consulta { get; set; }



            //chave estrangeira
            [ForeignKey("Paciente")]
            public int PacienteId { get; set; }
            public virtual Paciente? Paciente { get; set; }

            [ForeignKey("Dentista")]
            public int DentistaId { get; set; }
            public virtual Dentista? Dentista { get; set; }
     }
}
