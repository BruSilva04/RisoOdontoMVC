using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoDTO
{
    public class FuncionarioDTO
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cargo { get; set; }
        public string Login_Funcionario { get; set; }
        public string Senha { get; set; }
        public string TipoUsuarioId { get; set; }
    }
}
