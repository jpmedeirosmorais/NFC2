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
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//botão salvar
        {
            Usuario usuario = new Usuario();
            usuario.nome = textBox3.Text;
            usuario.username = textBox1.Text;
            usuario.senha = textBox3.Text;
            usuario.status = textBox5.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(numericUpDown1.Value,0));

            Banco.NovoUsuario(usuario);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox3.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox3.Focus();
        }

        private void F_NovoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
