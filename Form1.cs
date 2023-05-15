using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace GeniusTutorial
{
    public partial class Form1 : Form
    {
        List<string> SequenciaCores = new List<string>();
        List<string> SequenciaJogador = new List<string>();
        string[] cores = { "Vermelho", "Amarelo", "Azul", "Verde" };
        string atualJogador, atualCor;
        int pontos, indexLista;
        bool podeJogar;
        Random rdn = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void SortearCores()
        {
            atualCor = cores[rdn.Next(0, cores.Length)];
            SequenciaCores.Add(atualCor);

            foreach (var cor in SequenciaCores)
            {
                Application.DoEvents();
                Thread.Sleep(250);
                MostrarCor(cor);
            }
            PodeJogar();
        }

        private void MostrarCor(string atualCor)
        {
            switch (atualCor)
            {
                case "Vermelho":
                    pbVermelho.BackColor = Color.Red;
                    SystemSounds.Exclamation.Play();
                    Application.DoEvents();
                    Thread.Sleep(800);
                    pbVermelho.BackColor = Color.DarkRed;
                    break;

                case "Amarelo":
                    pbAmarelo.BackColor = Color.Yellow;
                    SystemSounds.Beep.Play();
                    Application.DoEvents();
                    Thread.Sleep(800);
                    pbAmarelo.BackColor = Color.Goldenrod;
                    break;

                case "Azul":
                    pbAzul.BackColor = Color.Cyan;
                    SystemSounds.Asterisk.Play();
                    Application.DoEvents();
                    Thread.Sleep(800);
                    pbAzul.BackColor = Color.Blue;
                    break;

                case "Verde":
                    pbVerde.BackColor = Color.Lime;
                    SystemSounds.Hand.Play();
                    Application.DoEvents();
                    Thread.Sleep(800);
                    pbVerde.BackColor = Color.DarkGreen;
                    break;


            }
        }

        private void PodeJogar()
        {
            foreach (PictureBox pb in Controls.OfType<PictureBox>())
            {
                pb.Enabled = true;
            }

            podeJogar = true;
        }

        private void CliqueReferencia_Clik(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (podeJogar)
            {
                atualJogador = pic.Tag.ToString();
                podeJogar = false;
                SequenciaJogador.Add(atualJogador);
                MostrarCor(atualJogador);

                if (SequenciaJogador[indexLista] == SequenciaCores[indexLista])
                {
                    indexLista++; pontos++; lblPontos.Text = "Pontos: " + pontos.ToString();
                    ChecarFinal();
                }
                else
                {
                    MessageBox.Show("Sequência incorreta! Fim de jogo.");
                }
            }
        }

        private void ChecarFinal()
        {
            if (indexLista == SequenciaCores.Count)
            {
                Application.DoEvents();
                Thread.Sleep(450);
                indexLista = 0;
                SequenciaJogador.Clear();
                SortearCores();
            }
            else
            {
                podeJogar = true;
            }
        }

        private void MenuReferencia_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            switch (menu.Tag.ToString())
            {
                case "Inicio":
                    pontos = 0; lblPontos.Text = "Pontos: " + pontos.ToString();
                    indexLista = 0; podeJogar = false;
                    SequenciaCores.Clear(); SequenciaJogador.Clear();
                    SortearCores();
                    break;

                case "Sobre":
                    if (podeJogar)
                    {
                        string infos = "Nome do jogo: Genius \n Copiado por: Tulio";
                        MessageBox.Show(infos, "Sobre o jogo");
                    }
                    break;

                case "Sair":
                    DialogResult msg = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo);
                    if (msg == DialogResult.Yes) { Application.Exit(); }
                    break;
            }
        }
    }
}
