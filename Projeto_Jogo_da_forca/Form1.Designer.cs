namespace Projeto_Jogo_da_Forca
{
    partial class frmJogodaforca
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogodaforca));
            this.pnJogo = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txbDLetras = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbDica = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btOK = new System.Windows.Forms.Button();
            this.txbLetra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTrestantes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotalTentativas = new System.Windows.Forms.Label();
            this.txbPalavra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.pnMSG = new System.Windows.Forms.Panel();
            this.pbWin = new System.Windows.Forms.PictureBox();
            this.pbGameover = new System.Windows.Forms.PictureBox();
            this.btMenu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnJogo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnMSG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameover)).BeginInit();
            this.SuspendLayout();
            // 
            // pnJogo
            // 
            this.pnJogo.Controls.Add(this.lblTempo);
            this.pnJogo.Controls.Add(this.groupBox5);
            this.pnJogo.Controls.Add(this.groupBox4);
            this.pnJogo.Controls.Add(this.groupBox3);
            this.pnJogo.Controls.Add(this.groupBox2);
            this.pnJogo.Controls.Add(this.groupBox1);
            this.pnJogo.Controls.Add(this.txbPalavra);
            this.pnJogo.Controls.Add(this.label1);
            this.pnJogo.Location = new System.Drawing.Point(2, 12);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(802, 375);
            this.pnJogo.TabIndex = 0;
            this.pnJogo.Visible = false;
            this.pnJogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnJogo_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txbDLetras);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(5, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(785, 54);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Letras Digitadas";
            // 
            // txbDLetras
            // 
            this.txbDLetras.Enabled = false;
            this.txbDLetras.Location = new System.Drawing.Point(0, 22);
            this.txbDLetras.Name = "txbDLetras";
            this.txbDLetras.Size = new System.Drawing.Size(776, 26);
            this.txbDLetras.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbDica);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(4, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(786, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dica:";
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDica.Location = new System.Drawing.Point(6, 22);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(45, 20);
            this.lbDica.TabIndex = 0;
            this.lbDica.Text = "Dica";
            this.lbDica.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btOK);
            this.groupBox3.Controls.Add(this.txbLetra);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 120);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escreva uma letra";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(6, 70);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(527, 29);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "Verificar";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txbLetra
            // 
            this.txbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLetra.Location = new System.Drawing.Point(6, 38);
            this.txbLetra.MaxLength = 1;
            this.txbLetra.Name = "txbLetra";
            this.txbLetra.Size = new System.Drawing.Size(527, 26);
            this.txbLetra.TabIndex = 0;
            this.txbLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTrestantes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(580, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 60);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tentativas restantes";
            // 
            // lbTrestantes
            // 
            this.lbTrestantes.AutoSize = true;
            this.lbTrestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrestantes.Location = new System.Drawing.Point(88, 22);
            this.lbTrestantes.Name = "lbTrestantes";
            this.lbTrestantes.Size = new System.Drawing.Size(25, 26);
            this.lbTrestantes.TabIndex = 0;
            this.lbTrestantes.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalTentativas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(580, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de tentativas";
            // 
            // lbTotalTentativas
            // 
            this.lbTotalTentativas.AutoSize = true;
            this.lbTotalTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTentativas.Location = new System.Drawing.Point(88, 22);
            this.lbTotalTentativas.Name = "lbTotalTentativas";
            this.lbTotalTentativas.Size = new System.Drawing.Size(25, 26);
            this.lbTotalTentativas.TabIndex = 0;
            this.lbTotalTentativas.Text = "5";
            // 
            // txbPalavra
            // 
            this.txbPalavra.Enabled = false;
            this.txbPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPalavra.Location = new System.Drawing.Point(3, 43);
            this.txbPalavra.Name = "txbPalavra";
            this.txbPalavra.Size = new System.Drawing.Size(787, 32);
            this.txbPalavra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifique a palavra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(2, 401);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(299, 37);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Iniciar";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnMSG
            // 
            this.pnMSG.Controls.Add(this.pbWin);
            this.pnMSG.Controls.Add(this.pbGameover);
            this.pnMSG.Location = new System.Drawing.Point(2, 2);
            this.pnMSG.Name = "pnMSG";
            this.pnMSG.Size = new System.Drawing.Size(802, 393);
            this.pnMSG.TabIndex = 7;
            this.pnMSG.Visible = false;
            // 
            // pbWin
            // 
            this.pbWin.Image = ((System.Drawing.Image)(resources.GetObject("pbWin.Image")));
            this.pbWin.Location = new System.Drawing.Point(7, 4);
            this.pbWin.Name = "pbWin";
            this.pbWin.Size = new System.Drawing.Size(786, 381);
            this.pbWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWin.TabIndex = 1;
            this.pbWin.TabStop = false;
            // 
            // pbGameover
            // 
            this.pbGameover.Image = ((System.Drawing.Image)(resources.GetObject("pbGameover.Image")));
            this.pbGameover.Location = new System.Drawing.Point(7, 4);
            this.pbGameover.Name = "pbGameover";
            this.pbGameover.Size = new System.Drawing.Size(786, 381);
            this.pbGameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameover.TabIndex = 0;
            this.pbGameover.TabStop = false;
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(533, 401);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(271, 37);
            this.btMenu.TabIndex = 8;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(374, 198);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 26);
            this.lblTempo.TabIndex = 9;
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2.Location = new System.Drawing.Point(432, 407);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(19, 26);
            this.lblT2.TabIndex = 10;
            this.lblT2.Text = ":";
            this.lblT2.Visible = false;
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1.Location = new System.Drawing.Point(342, 407);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(84, 26);
            this.lblT1.TabIndex = 10;
            this.lblT1.Text = "Tempo";
            this.lblT1.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmJogodaforca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.lblT1);
            this.Controls.Add(this.lblT2);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.pnMSG);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pnJogo);
            this.Name = "frmJogodaforca";
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.frmJogodaforca_Load);
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnMSG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox txbPalavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbLetra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTrestantes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotalTentativas;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txbDLetras;
        private System.Windows.Forms.Panel pnMSG;
        private System.Windows.Forms.PictureBox pbWin;
        private System.Windows.Forms.PictureBox pbGameover;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

