using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Jogo_da_Forca
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void mostrarJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iniciarJogoToolStripMenuItem_Click(object sender, EventArgs e)     //Botão de iniciar jogo menu.
        {
            frmJogodaforca outroForm = new frmJogodaforca();
            this.Hide();
            outroForm.ShowDialog();
            this.Close();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)        //Seção de creditos.
        {
            frmCreditos fim = new frmCreditos();
            this.Hide();
            fim.ShowDialog();

        }
    }
}
