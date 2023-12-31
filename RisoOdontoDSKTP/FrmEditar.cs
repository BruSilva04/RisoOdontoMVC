﻿using RisoOdontoBLL;
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
    public partial class FrmEditar : Form
    {
        public FrmEditar()
        {
            InitializeComponent();
        }

        PacienteBLL objBLL = new PacienteBLL();
        PacienteDTO objDTO = new PacienteDTO();

        //Load form
        private void FrmEditar_Load_1(object sender, EventArgs e)
        {
            gBox1.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
        }

        //validaPage
        public bool validaForm()
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
        //Fechar
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        //Pesquisar
        private void btnPesquisar_Click_1(object sender, EventArgs e)
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
                txtData.Text = objDTO.DataNascimento.ToString();
                txtTelefone.Text = objDTO.Telefone.ToString();
                txtCpf.Text = objDTO.CPF;
                txtCidade.Text = objDTO.Cidade;
                txtEndereco.Text = objDTO.Endereco;
                txtSenha.Text = objDTO.Senha;




                btnEditar.Enabled = true;
            }
        }

        //Editar - Liberação dos campos para acesso
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            gBox1.Enabled = true;
            btnSalvar.Enabled = true;
            txtId.Enabled = false;
            btnPesquisar.Enabled = false;
        }

        //Update - salvando as alterações
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (validaForm())
            {
                PacienteDTO objDTO = new PacienteDTO();

                objDTO.IdPaciente = Convert.ToInt32(txtId.Text);

                //preeencher os dados fornecidos pelo usuári
                objDTO.Nome = txtNome.Text;
                objDTO.Email = txtEmail.Text;
                objDTO.Telefone = Convert.ToInt32(txtTelefone.Text);
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
                objDTO.DataNascimento = Convert.ToDateTime(txtData.Text);
                objDTO.CPF = txtCpf.Text;
                objDTO.Cidade = txtCidade.Text;
                objDTO.Endereco = txtEndereco.Text;
                objDTO.Senha = txtSenha.Text;


                //Editando as informações
                objBLL.Editar(objDTO);
                Limpar.ClearControl(this);
                txtId.Enabled = true;
                txtId.Focus();
                btnPesquisar.Enabled = true;
                btnEditar.Enabled = false;
                gBox1.Enabled = false;
                btnSalvar.Enabled = false;

                MessageBox.Show($"Paciente {objDTO.Nome} editado com sucesso!!");

            }
        }

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
