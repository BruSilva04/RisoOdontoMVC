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
                string nome = txtUsuario.Text.Trim();
                string senha = txtSenha.Text.Trim();

                FuncionarioDTO obj = new FuncionarioDTO();
                FuncionarioBLL objBLL = new FuncionarioBLL();

                obj = objBLL.AuteticarUsuario(nome, senha);
                if (obj != null)
                {
                    switch (obj.TipoUsuarioId)
                    {
                        case "1":
                            Session.Nome = txtUsuario.Text.Trim();
                            FrmLogin formuInicial = new FrmLogin();
                            formuInicial.Show();
                            this.Visible = false;
                            break;
                        case "2":
                            Session.Nome = txtUsuario.Text.Trim();
                            FrmLogin formOutros = new FrmLogin();
                            formOutros.Show();
                            this.Visible = false;
                            break;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtUsuario.Focus();
        }

    }
}
