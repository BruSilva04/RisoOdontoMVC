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
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }

        //Instanciando
        PacienteBLL objBLL = new PacienteBLL();

        PacienteDTO objDTO = new PacienteDTO();
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

                btnPesquisar.Enabled = true;
            }
            txtId.Enabled = btnPesquisar.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtId.Enabled = btnPesquisar.Enabled = true;
            btnLimpar.Enabled = false;
            txtId.Focus();
        }
    }
}
