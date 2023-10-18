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
            MessageBox.Show($"{Session.Nome.ToUpper()} sua sessão será finalizada", "Atenção", MessageBoxButtons.OK);
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
    }
}
