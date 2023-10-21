using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoDTO
{
    public class PacienteDTO
    {
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Senha { get; set; }
        public string TipoUsuarioId { get; set; }
    }
}
