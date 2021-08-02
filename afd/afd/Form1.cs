using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace afd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maquinaDeDoce_Click(object sender, EventArgs e)
        {
            maquina Tela = new maquina();
            Tela.Show();
            this.Hide(); // Para ocultar a antiga janela
        }

        private void elevador_Click(object sender, EventArgs e)
        {
            elevador Tela = new elevador();
            Tela.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
