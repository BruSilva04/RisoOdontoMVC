using RisoOdontoBLL;
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
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
            

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void Notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void Word_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro obj = new FrmCadastro();
            obj.ShowDialog();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            FrmListar obj = new FrmListar();
            obj.ShowDialog();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            FrmExcluir obj = new FrmExcluir();
            obj.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            FrmEditar obj = new FrmEditar();
            obj.ShowDialog();
        }
    }
}
