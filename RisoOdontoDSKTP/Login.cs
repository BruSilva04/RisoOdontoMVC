﻿using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace RisoOdontoDSKTP
{
    public partial class Login : Form
    {
        public Login()
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
                UsuarioBLL objBLL = new UsuarioBLL();

                obj = objBLL.AuteticarUsuario(nome, senha);
                if (obj != null)
                {
                    switch (obj.UsuarioTp)
                    {
                        case "1":
                            Session.nomeUsuario = txtUser.Text.Trim();
                            MDI_Adm formuAdm = new MDI_Adm();
                            formuAdm.Show();
                            this.Visible = false;
                            break;
                        case "2":
                            Session.nomeUsuario = txtUser.Text.Trim();
                            MDI_Outros formOutros = new MDI_Outros();
                            formOutros.Show();
                            this.Visible = false;
                            break;

                    }
                }
                else
                {
                    MessageBox.Show($"Usuário {txtUser.Text} não cadastrado !!");
                    Limpar.ClearControl(this);
                    txtUser.Focus();
                }


            }
            catch (Exception)
            {

                MessageBox.Show($"Usuário {txtUser.Text} não cadastrado !!");
            }
        }
    }
}
