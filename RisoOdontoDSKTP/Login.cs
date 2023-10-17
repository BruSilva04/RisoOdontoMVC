using RisoOdontoBLL;
using RisoOdontoDSKTP.Utilitarios;
using RisoOdontoDTO;
using System;
using System.Drawing;
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

        bool isDark = false;

        public void DarkMode()
        {
            if (isDark)
            {
                if (chkDark.Checked)
                {
                    this.BackColor = Color.Black;
                    lblUser.ForeColor = Color.White;
                    lblSenha.ForeColor = Color.White;
                    btnCancelar.ForeColor = Color.White;
                    btnEntrar.ForeColor = Color.Black;
                    chkDark.ForeColor = Color.White;
                    chkLight.ForeColor = Color.White;

                    foreach (Control ct in this.Controls)
                        if (ct is Panel)
                            (ct as Panel).ForeColor = Color.White;
                    chkLight.CheckState = CheckState.Unchecked;
                }

            }
            else
            {
                if(chkLight.Checked)
                {              
                this.BackColor = Color.White;
                lblUser.ForeColor = Color.Black;
                lblSenha.ForeColor = Color.Black;
                btnCancelar.ForeColor = Color.Black;
                btnEntrar.ForeColor = Color.White;
                chkDark.ForeColor = Color.Black;
                chkLight.ForeColor = Color.Black;

                    foreach (Control ct in this.Controls)
                    if (ct is Panel)
                        (ct as Panel).ForeColor = Color.Black;
                    chkDark.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void chkDark_CheckedChanged(object sender, EventArgs e)
        {
            isDark = true;
            DarkMode();
        }

        private void chkLight_CheckedChanged(object sender, EventArgs e)
        {
            isDark = false;
            DarkMode();
        }
    }
}
