using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFC2
{
    public partial class NovoJogador : Form
    {
        public NovoJogador()
        {
            InitializeComponent();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox3.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Jogador jogador = new Jogador();
            jogador.nome = textBox3.Text;
            jogador.idade = textBox1.Text;
            jogador.nacionalidade = textBox2.Text;
            jogador.posicao = textBox5.Text;

            Banco.NovoJogador(jogador);
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox3.Focus();
        }
    }
}
