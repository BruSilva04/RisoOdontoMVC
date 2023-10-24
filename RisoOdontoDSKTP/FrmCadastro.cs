using RisoOdontoBLL;
using RisoOdontoDSKTP.Utilitarios;
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
        PacienteBLL objBLL = new PacienteBLL();
        PacienteDTO objCad = new PacienteDTO();
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
                MessageBox.Show("Digite o nome do Paciente !!");
                txtNome.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Digite o email do Paciente !!");
                txtEmail.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Digite o Telefone do Paciente!!");
                txtTelefone.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtData.Text))
            {
                MessageBox.Show("Digite a data de nascimento do usuário !!");
                txtData.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MessageBox.Show("Digite o CPF do Paciente !!");
                txtCpf.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Digite a cidade do Paciente !!");
                txtCidade.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Digite o Endereço do Paciente !!");
                txtEndereco.Focus();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                PacienteDTO objDTO = new PacienteDTO();

                //preeencher os dados fornecidos pelo usuári
                objDTO.Nome = txtNome.Text.Trim();
                objDTO.Email = txtEmail.Text.Trim();
                objDTO.Telefone = Convert.ToInt32(txtSenha.Text);
                //ajustar a data
                DateTime dt;
                if (DateTime.TryParse(txtData.Text, out dt))
                {
                    objDTO.DataNascimento = dt;
                }
                else
                {
                    MessageBox.Show("Digite uma data válida!!");
                    txtData.Text = string.Empty;
                    txtData.Focus();
                    return;
                }

                objDTO.CPF = txtCpf.Text.Trim();
                objDTO.Cidade = txtCidade.Text.Trim();
                objDTO.Endereco = txtEndereco.Text.Trim();
                objDTO.Senha = txtSenha.Text.Trim();
                objDTO.TipoUsuarioId = cbo1.SelectedValue.ToString();

                //cadastrar
                objBLL.Cadastrar(objCad);
                Limpar.ClearControl(this);
                btnCadastrar.Enabled = true;

                MessageBox.Show($"Paciente {objDTO.Nome} Cadastrado com sucesso!!");
            }
        }
    }
}
