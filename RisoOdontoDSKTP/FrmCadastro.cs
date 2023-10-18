using RisoOdontoBLL;
using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisoOdontoDSKTP
{
    public partial class FrmCadastro : Form
    {

        //instanciando
        FuncionarioBLL objBLL = new FuncionarioBLL();
        FuncionarioDTO objCad = new FuncionarioDTO();
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //load
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            CarregaCbo1();
            cbo1.Enabled = false;
        }

        //carrega cbo1
        public void CarregaCbo1()
        {
            //dispaly para exibir
            cbo1.ValueMember = "IdTipoUsuario";
            cbo1.DisplayMember = "DescricaoTipoUsuario";

            cbo1.DataSource = objBLL.CarregaTpUsuarioDDL().ToList();
        }

        //validaPage
        public bool ValidaForm()
        {
            //criando variavel de retorno
            bool validator;

            //estrutura de checagem
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Digite o nome do usuário !!");
                txtNome.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Digite o email do usuário !!");
                txtEmail.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtData.Text))
            {
                MessageBox.Show("Digite a data de nascimento do usuário !!");
                txtData.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtCargo.Text))
            {
                MessageBox.Show("Digite o Cargo do !!");
                txtCargo.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Digite a senha do usuário !!");
                txtSenha.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Digite a senha do usuário !!");
                txtSenha.Focus();
                validator = false;
            }
            else
            {
                validator = true;
            }

            return validator;

        }

    }
}
