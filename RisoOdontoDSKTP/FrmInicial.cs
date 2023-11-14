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
        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
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
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro obj = new FrmCadastro();
            obj.ShowDialog();
        }
        private void cadastroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro obj = new FrmCadastro();
            obj.ShowDialog();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            FrmListar obj = new FrmListar();
            obj.ShowDialog();
        }
        private void listarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListar obj = new FrmListar();
            obj.ShowDialog();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            FrmExcluir obj = new FrmExcluir();
            obj.ShowDialog();
        }
        private void excluirPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluir obj = new FrmExcluir();
            obj.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            FrmEditar obj = new FrmEditar();
            obj.ShowDialog();
        }
        private void editarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditar obj = new FrmEditar();
            obj.ShowDialog();
        }

        private void Agenda_Click(object sender, EventArgs e)
        {
            FrmAgenda obj = new FrmAgenda();
            obj.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda obj = new FrmAgenda();
            obj.ShowDialog();
        }

        


    }
}
