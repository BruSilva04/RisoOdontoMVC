using RisoOdontoBLL;
using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RisoOdontoUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //instanciar os objetos DTO BLL
                PacienteDTO usuario = new PacienteDTO();
                PacienteBLL objBLL = new PacienteBLL();

                //pegar os dados fornecidos pelo usuario
                string objEmail = txtEmail.Text;
                string objSenha = txtSenha.Text;

                //chamar o metodo na BLL
                usuario = objBLL.AutenticarPaciente(objEmail, objSenha);


                //checar o tipo de usuario
                if (usuario != null)
                {

                    lblMessage.Text = $"Bem Vindo {usuario.Nome}";
                }

            }
            catch (Exception)
            {

                lblMessage.Text = $"Usuario {txtEmail.Text} não cadastrado!!! ";
            }
        }
    }
}