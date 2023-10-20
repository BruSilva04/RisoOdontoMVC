using RisoOdontoDAL;
using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoBLL
{
    public class PacienteBLL
    {
        //variavel
        PacienteDAL objBLL = new PacienteDAL();

        //autenticar
        public PacienteDTO AutenticarPaciente(string Email, string Senha)
        {
            PacienteDTO paciente = objBLL.AutenticarCliente(Email, Senha);
            return paciente;
        }

        //CRUD
        //Create
        public void Cadastrar(PacienteDTO objCad)
        {
            objBLL.CadastrarCliente(objCad);
        }

        //Read
        public List<PacienteDTO> Listar()
        {
            return objBLL.ListarPaciente();
        }

        //Delete
        public void Excluir(int objDel)
        {
            objBLL.ExcluirPaciente(objDel);
        }

        //Update
        public void Editar(PacienteDTO objEdita)
        {
            objBLL.EditarPaciente(objEdita);
        }

        //CarregaDDL
        public List<TipoUsuarioDTO> CarregaTpUsuarioDDL()
        {
            return objBLL.CarregaDDL();
        }
    }
}
