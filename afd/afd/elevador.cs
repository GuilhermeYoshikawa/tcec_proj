using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace afd
{
    public partial class elevador : Form
    {
        public elevador()
        {
            InitializeComponent();
        }

        private void elevador_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Se não houver nenhum formulário aberto sai da aplicação
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms) // caso tenho algum formulário aberto ele vikta para o form1
                {
                    if (formAberto is Form1)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        int andar = 0;
        int andarAtual = 0;

        private void bloquearCampos()
        {
            btnFechar.Enabled = false;
            btnAbrir.Enabled = false;
            btnTerreo.Enabled = false;
            btnPrimeiroAndar.Enabled = false;
            btnSegundoAndar.Enabled = false;
            btnTerceiroAndar.Enabled = false;
        }

        private void restart()
        {
            btnFechar.Enabled = true;
            btnAbrir.Enabled = true;
            btnTerreo.Enabled = true;
            btnPrimeiroAndar.Enabled = true;
            btnSegundoAndar.Enabled = true;
            btnTerceiroAndar.Enabled = true;
            pictureBox1.BackgroundImage = Properties.Resources.porta_aberta;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.porta_fechada;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.porta_aberta;
        }

        private void btnTerreo_Click(object sender, EventArgs e)
        {
            andar = 0;
            lblAndar.Text = andar.ToString();
        }

        private void btnPrimeiroAndar_Click(object sender, EventArgs e)
        {
            andar = 1;
            lblAndar.Text = andar.ToString();
        }

        private void btnSegundoAndar_Click(object sender, EventArgs e)
        {
            andar = 2;
            lblAndar.Text = andar.ToString();
        }

        private void btnTerceiroAndar_Click(object sender, EventArgs e)
        {
            andar = 3;
            lblAndar.Text = andar.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bloquearCampos();
            pictureBox1.BackgroundImage = Properties.Resources.porta_fechada;

            if (andar != andarAtual)
            {
                timer1.Start(); // dispara o timer
            }
            else
            {
                restart();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (andar > andarAtual)
            {
                andarAtual++;
                lblAndarAtual.Text = andarAtual.ToString();
                seta_elevador.BackgroundImage = Properties.Resources.seta_subindo;
                if (andarAtual == andar)
                {
                    timer1.Stop();
                    pictureBox1.BackgroundImage = Properties.Resources.porta_aberta;
                    restart();
                }
            }
            else
            {
                andarAtual--;
                lblAndarAtual.Text = andarAtual.ToString();
                seta_elevador.BackgroundImage = Properties.Resources.seta_descendo;
                if (andarAtual == andar)
                {
                    timer1.Stop();
                    pictureBox1.BackgroundImage = Properties.Resources.porta_aberta;       
                    restart();
                }
            }
        }
    }
}
