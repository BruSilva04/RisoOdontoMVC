using RisoOdontoBLL;
using RisoOdontoDSKTP.Utilitarios;
using RisoOdontoDTO;
using System;
using System.Windows.Forms;

namespace RisoOdontoDSKTP
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //pegar as informacoes do usuario
                string Login_Funcionario = txtUsuario.Text.Trim();
                string senha = txtSenha.Text.Trim();

                FuncionarioDTO obj = new FuncionarioDTO();
                FuncionarioBLL objBLL = new FuncionarioBLL();

                obj = objBLL.AuteticarUsuario(Login_Funcionario, senha);
                if (obj != null)
                {
                    switch (obj.TipoUsuarioId)
                    {
                        case "1":
                            Session.Login_Funcionario = txtUsuario.Text.Trim();
                            FrmLogin formuLogin = new FrmLogin();
                            formuLogin.Show();
                            this.Visible = false;

                            break;
                        //case "2":
                            //Session.EmailFuncionario = txtUsuario.Text.Trim();
                            //MDI_Outros formOutros = new MDI_Outros();
                            //formOutros.Show();
                            //this.Visible = false;
                            //break;

                    }
                }
                else
                {
                    MessageBox.Show($"Usuário {txtUsuario.Text} não cadastrado !!");
                    Limpar.ClearControl(this);
                    txtUsuario.Focus();
                }


            }
            catch (Exception)
            {

                MessageBox.Show($"Usuário {txtUsuario.Text} não cadastrado !!");
            }
        }
    }
}
