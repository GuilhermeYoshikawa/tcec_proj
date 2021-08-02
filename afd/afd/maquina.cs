using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace afd
{
    public partial class maquina : Form
    {
        public maquina()
        {
            InitializeComponent();
        }

        private void maquina_FormClosed(object sender, FormClosedEventArgs e)
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

        int saldo = 0;
        decimal valorDoDoce = 0;
        decimal troco = 0;

        private void limite()
        {
            if (saldo == 10)
            {
                btnUmReal.Enabled = false;
                btnUmReal.BackgroundImage = Properties.Resources.moeda1_disabled;

                btnDoisReais.Enabled = false;
                btnDoisReais.BackgroundImage = Properties.Resources.nota2_disabled;

                btnCincoReais.Enabled = false;
                btnCincoReais.BackgroundImage = Properties.Resources.nota5_disabled;
            }
            else if (saldo > 8)
            {
                btnDoisReais.Enabled = false;
                btnDoisReais.BackgroundImage = Properties.Resources.nota2_disabled;
            }
            else if (saldo > 5)
            {
                btnCincoReais.Enabled = false;
                btnCincoReais.BackgroundImage = Properties.Resources.nota5_disabled;
            }
        }

        private void trocoTotal()
        {
            if (saldo <= valorDoDoce)
            {
                troco = 0;
            }
            else
            {
                troco = saldo - valorDoDoce;
                lblTroco.Text = String.Format("{0:N2}", troco);
            }
        }

        private void bloquearCampos()
        {
            btnUmReal.Enabled = false;
            btnUmReal.BackgroundImage = Properties.Resources.moeda1_disabled;

            btnDoisReais.Enabled = false;
            btnDoisReais.BackgroundImage = Properties.Resources.nota2_disabled;

            btnCincoReais.Enabled = false;
            btnCincoReais.BackgroundImage = Properties.Resources.nota5_disabled;

            btnDoceA.Enabled = false;
            btnDoceB.Enabled = false;
            btnDoceC.Enabled = false;
        }

        private void restart()
        {
            btnUmReal.Enabled = true;
            btnUmReal.BackgroundImage = Properties.Resources.moeda1;

            btnDoisReais.Enabled = true;
            btnDoisReais.BackgroundImage = Properties.Resources.nota2;

            btnCincoReais.Enabled = true;
            btnCincoReais.BackgroundImage = Properties.Resources.nota5;

            btnDoceA.Enabled = true;
            btnDoceB.Enabled = true;
            btnDoceC.Enabled = true;

            saldo = 0;
            valorDoDoce = 0;
            troco = 0;

            lblSaldo.Text = String.Format("0,00", lblSaldo);
            lblValorDoDoce.Text = String.Format("0,00", lblValorDoDoce);
            lblTroco.Text = String.Format("0,00", lblTroco);

            btnPegarTroco.Enabled = false;
            btnPegar.Enabled = false;

            imgDoceA.Image = Properties.Resources.docea;
            imgDoceB.Image = Properties.Resources.doceb;
            imgDoceC.Image = Properties.Resources.docec;
        }

        private void semTroco()
        {
            if (saldo != 0 && valorDoDoce <= saldo && troco == 0)
            {
                bloquearCampos();
                btnPegar.Enabled = true;
                btnPegarTroco.Enabled = false;
            }
        }

        private void comTroco()
        {
            if (saldo != 0 && valorDoDoce <= saldo && troco > 0)
            {
                bloquearCampos();
                btnPegar.Enabled = true;
                btnPegarTroco.Enabled = true;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDoceA_Click(object sender, EventArgs e)
        {
            imgDoceA.Image = Properties.Resources.docea;
            imgDoceB.Image = Properties.Resources.doceb_disabled;
            imgDoceC.Image = Properties.Resources.docec_disabled;
            valorDoDoce = 6;
            lblValorDoDoce.Text = String.Format("{0:N2}", valorDoDoce);
        }

        private void btnDoceB_Click(object sender, EventArgs e)
        {
            imgDoceA.Image = Properties.Resources.docea_disabled;
            imgDoceB.Image = Properties.Resources.doceb;
            imgDoceC.Image = Properties.Resources.docec_disabled;
            valorDoDoce = 7;
            lblValorDoDoce.Text = String.Format("{0:N2}", valorDoDoce);
        }

        private void btnDoceC_Click(object sender, EventArgs e)
        {
            imgDoceA.Image = Properties.Resources.docea_disabled;
            imgDoceB.Image = Properties.Resources.doceb_disabled;
            imgDoceC.Image = Properties.Resources.docec;
            valorDoDoce = 8;
            lblValorDoDoce.Text = String.Format("{0:N2}", valorDoDoce);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            trocoTotal();
            semTroco();
            comTroco();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, btnUmReal.Width, btnUmReal.Height);
            btnUmReal.Region = new Region(forma);
        }

        private void btnUmReal_Click(object sender, EventArgs e)
        {
            saldo = saldo + 1;
            lblSaldo.Text = String.Format("{0:N2}", saldo);
            limite();
        }

        private void btnDoisReais_Click(object sender, EventArgs e)
        {
            saldo = saldo + 2;
            lblSaldo.Text = String.Format("{0:N2}", saldo);
            limite();
        }

        private void btnCincoReais_Click(object sender, EventArgs e)
        {
            saldo = saldo + 5;
            lblSaldo.Text = String.Format("{0:N2}", saldo);
            limite();
        }

        private void btnPegarTroco_Click(object sender, EventArgs e)
        {
            lblSaldo.Text = String.Format("0,00", lblSaldo);
            lblValorDoDoce.Text = String.Format("0,00", lblValorDoDoce);
            lblTroco.Text = String.Format("0,00", lblTroco);
            MessageBox.Show("Você pegou o troco!");
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}
