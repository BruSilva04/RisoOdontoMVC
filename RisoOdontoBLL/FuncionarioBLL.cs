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
        public void CadastrarUsuario(UsuarioDTO objCad)
        {
            objBLL.Cadastrar(objCad);
        }

        //Read
        public List<UsuarioDTO> ListarUsuario()
        {
            return objBLL.Listar();
        }

        //Delete
        public void ExcluirUsuario(int objDel)
        {
            objBLL.Excluir(objDel);
        }

        //Update
        public void EditarUsuario(UsuarioDTO objEdita)
        {
            objBLL.Editar(objEdita);
        }

        //BuscaPorId
        public UsuarioDTO BuscaUsuarioPorId(int objId)
        {
            return objBLL.BuscaPorId(objId);
        }

        //BuscaPorNome
        public UsuarioDTO BuscaUsuarioPorNome(string objNome)
        {
            return objBLL.BuscaPorNome(objNome);
        }

        //CarregaDDL
        public List<TipoUsuarioDTO> CarregaTpUsuarioDDL()
        {
            return objBLL.CarregaDDL();
        }
    }
}
