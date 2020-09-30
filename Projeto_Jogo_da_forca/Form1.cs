//Marcello de abreu da Silva.

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
    public partial class frmJogodaforca : Form
    {
        private string[] palavras;                  //Vetor para armazenar as palavras.
        private string[] dicas;                     //Vetor para armazenar as letras.
        private string palavra;                     //Váriavel para inserir a palavra.
        private string tela;                        //Váriavel para mostrar a palavra da tela.
        private int tentativas;                     //Váriavel para armazenar as tentativas.
        private int pospalavra;                     //Váriavel para armazenar as palavras identificadas pelo usuário.
        public int M=0, S=0;


        public frmJogodaforca()
        {
            InitializeComponent();
            this.IniciaVetro();                     //Inicia os vetores.

        }

        private void IniciaVetro()
        {
            palavras = new string[10];
            dicas = new string[10];


            palavras[0] = "banana";
            dicas[0] = "Fruta amarela.";

            palavras[1]= "monitor";
            dicas[1]= "Periferico.";

            palavras[2]= "teclado";
            dicas[2]= "Periferico.";

            palavras[3]= "laranja";
            dicas[3]= "Tipo de fruta.";

            palavras[4]= "mclaren";
            dicas[4]= "Carro.";

            palavras[5]= "uva";
            dicas[5]= "Fruta.";

            palavras[6]= "celular";
            dicas[6]= "Eletrônico.";

            palavras[7]= "copic";
            dicas[7]= "Melhor marcador do mundo.";

            palavras[8]= "strogonof";
            dicas[8]= "Comida";

            palavras[9]= "macarrao";
            dicas[9]= "Comida";
        }               //Vetor para armazenar as palavras o jogo.

        private void IniciaJogo()                   //Vetor para iniciar o jogo.
        {
            Random r = new Random();
            pospalavra = r.Next(0, 10);
            palavra = palavras[pospalavra];
            tela = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "#";

            }
            txbPalavra.Text = tela;
            lbDica.Text = dicas[pospalavra];
            tentativas = 5;
            lbTotalTentativas.Text = tentativas.ToString();
            lbTrestantes.Text = tentativas.ToString();
            txbDLetras.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)  //Botão de iniciar jogo.
        {
            pnMSG.Visible = false;
            pnJogo.Visible = true;
            btStart.Visible = false;
            btMenu.Visible = false;
            this.IniciaJogo();
            timer1.Enabled = true;
            S = 0;
            M = 0;
            notifyIcon1.ShowBalloonTip(20, "Jogo Inicializado", "Comece a jogar!", ToolTipIcon.Info);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)     //Botão de Jogar.
        {
           
            Boolean encontrou = false;
            char letra = '0';
            if (txbDLetras.Text.Length <= 0)
                txbDLetras.Text = txbDLetras.Text + txbLetra.Text;
            else
                txbDLetras.Text = txbDLetras.Text +", "+ txbLetra.Text;
            //int pletra = 0;
            try
            {
                letra = Convert.ToChar(txbLetra.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas letras.");       //Mensagem para colocar apenas letras.
            }
            
            string txt = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == letra)
                {
                    encontrou = true;
                    // pletra = i;
                    txt = txt + txbLetra.Text;
                }
                else
                {
                    txt = txt + tela[i];
                }
            }
            tela = txt;
            txbPalavra.Text = tela;
            txbLetra.Clear();
            if (encontrou == false)
            {
                tentativas--;
            }
            lbTrestantes.Text = tentativas.ToString();          //Seção de decremento das tentativas.

            if (txbPalavra.Text.IndexOf('#') == -1)             //Substitui os # pela letra correta.
            {
                pnJogo.Visible = false;
                pnMSG.Visible = true;
                pbWin.Visible = true;
                pbGameover.Visible = false;
                btStart.Visible = true;                         //Eventos de Ganhar o jogo.
                btMenu.Visible = true;
                timer1.Enabled = false;
                lblT2.Text = lblTempo.Text;
                lblT2.Visible = true;
                lblT1.Visible = true;
               
            }
            if (tentativas <= 0)
            {
                pnJogo.Visible = false;
                pnMSG.Visible = true;
                btStart.Visible = true;
                btMenu.Visible = true;
                pbWin.Visible = false;                          //Eventos de Game Over.
                pbGameover.Visible = true;
                timer1.Enabled = false;
                lblT2.Text = lblTempo.Text;
                lblT2.Visible = true;
                lblT1.Visible = true;
               
            }
            
        }

        private void btMenu_Click(object sender, EventArgs e)           //Botão do menu do jogo.
        {
            frmTelaInicial volta = new frmTelaInicial();
            this.Hide();
            volta.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)            //Área do crônometro.
        {
            S++;
            if (S>59)
            {
                S = 0;
                M++;
            }
            lblTempo.Text = (mudar(M))+":"+(mudar(S));                  //Mostrando o tempo em minutos e segundos.
        }

        private void pnJogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmJogodaforca_Load(object sender, EventArgs e)
        {

        }

        private string mudar(int T)
        {
            if (T > 9)
                return T.ToString();
            return $"0{T.ToString()}";
        }
    }
}
//Será que salvou ?