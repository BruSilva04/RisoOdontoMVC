using RisoOdontoDAL;
using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoBLL
{
    public class FuncionarioBLL
    {
        //variavel
        FuncionarioDAL objBLL = new FuncionarioDAL();

        //autenticar
        public FuncionarioDTO AuteticarUsuario(string nome, string senha)
        {
            FuncionarioDTO user = objBLL.Autenticar(nome, senha);

            return user;

        }

        //CRUD
        //Create
        public void CadastrarUsuario(FuncionarioDTO objCad)
        {
            objBLL.Cadastrar(objCad);
        }

  

        //Delete
        public void ExcluirUsuario(int objDel)
        {
            objBLL.Excluir(objDel);
        }

        //Update
        public void EditarUsuario(FuncionarioDTO objEdita)
        {
            objBLL.Editar(objEdita);
        }

        //CarregaDDL
        public List<TipoUsuarioDTO> CarregaTpUsuarioDDL()
        {
            return objBLL.CarregaDDL();
        }
    }
}
