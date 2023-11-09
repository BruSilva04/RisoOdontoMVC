using RisoOdontoDAL;
using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoBLL
{
    public class DentistaBLL
    {
        //variavel
        DentistaDAL objBLL = new DentistaDAL();

        //autenticar
        public DentistaDTO AutenticarPaciente(string Email, string Senha)
        {
            DentistaDTO dentista = objBLL.Autenticar(Email, Senha);
            return dentista;
        }

        //CRUD
        //Create
        public void Cadastrar(DentistaDTO objCad)
        {
            objBLL.Cadastrar(objCad);
        }


        //Delete
        public void Excluir(int objDel)
        {
            objBLL.Excluir(objDel);
        }

        //Update
        public void Editar(DentistaDTO objEdita)
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
