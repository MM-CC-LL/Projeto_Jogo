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
    public partial class frmCreditos : Form
    {
        public frmCreditos()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     //Seção de link.
        {
            System.Diagnostics.Process.Start("https://www.unifenas.br/");
        }

        private void button1_Click(object sender, EventArgs e)          //Botão voltar para o menu.
        {
            frmTelaInicial voltar = new frmTelaInicial();
            this.Hide();
            voltar.ShowDialog();
        }
    }
}
