using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoDTO
{
	public class DentistaDTO
	{

        public int IdDentista { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login_Dentista { get; set; }
        public string Senha { get; set; }

        public string Especialidade { get; set; }
    }
}
