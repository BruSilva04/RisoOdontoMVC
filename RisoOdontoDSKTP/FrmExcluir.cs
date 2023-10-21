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
    public partial class FrmExcluir : Form
    {

        PacienteBLL objBLL = new PacienteBLL();
        PacienteDTO objDTO = new PacienteDTO();
        public FrmExcluir()
        {
            InitializeComponent();
        }

        private void FrmExcluir_Load(object sender, EventArgs e)
        {
            CarregaCbo1();
            gBox1.Enabled = btnLimpar.Enabled = btnExcluir.Enabled = false;
        }

        //carrega cbo1
        public void CarregaCbo1()
        {
            cbo1.ValueMember = "IdTipoUsuario";
            cbo1.DisplayMember = "Descricao";
            cbo1.DataSource = objBLL.CarregaTpUsuarioDDL().ToList();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtId.Enabled = btnPesquisar.Enabled = true;
            btnExcluir.Enabled = btnLimpar.Enabled = false;
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Criando variável para armazenar escolha do usuário
            DialogResult msg = MessageBox.Show($"Deseja realmente Excluir o Paciente {txtNome.Text.ToUpper()} ??", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Manipulando o valor escolhido pelo usuario
            if (msg == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(txtId.Text.Trim());
                objBLL.Excluir(codigo);
                MessageBox.Show("Paciente Excluido com sucesso !!");
                Limpar.ClearControl(this);
                txtId.Enabled = btnPesquisar.Enabled = true;
                btnExcluir.Enabled = btnLimpar.Enabled = false;
                txtId.Focus();
            }
            else if (msg == DialogResult.No)
            {
                Limpar.ClearControl(this);
                txtId.Enabled = btnPesquisar.Enabled = true;
                btnExcluir.Enabled = btnLimpar.Enabled = false;
                txtId.Focus();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Preencha o campo id !!");
                txtId.Text = string.Empty;
                txtId.Focus();
                return;
            }

            int codigo;
            int.TryParse(txtId.Text, out codigo);

            if (objBLL.BuscaUsuarioPorId(codigo) == null)
            {
                MessageBox.Show("Id inválido !!");
                txtId.Text = string.Empty;
                txtId.Focus();
                return;
            }
            else
            {
                objDTO = objBLL.BuscaUsuarioPorId(codigo);
                txtNome.Text = objDTO.Nome;
                txtEmail.Text = objDTO.Email;
                txtTelefone.Text = objDTO.Telefone.ToString();
                txtData.Text = objDTO.DataNascimento.ToString();
                txtCpf.Text = objDTO.CPF;
                txtCidade.Text = objDTO.Cidade;
                txtEndereco.Text = objDTO.Endereco;
                txtSenha.Text = objDTO.Senha;

                cbo1.SelectedValue = Convert.ToInt32(objDTO.TipoUsuarioId);
                btnExcluir.Enabled = btnLimpar.Enabled = true;
            }
            txtId.Enabled = btnPesquisar.Enabled = false;
        }

        //permitir somente numeros
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }


    }
}
