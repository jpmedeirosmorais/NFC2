using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFC2
{
    public partial class Form1 : Form
    {
        string CaminhoDocumento = string.Empty;
        public Form1()
        {


            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
            if (Globais.logado)
            {
                InitializeComponent();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string nomearquivo = saveFileDialog1.FileName;
            saveFileDialog1.Title = "Salvar Como";
            saveFileDialog1.DefaultExt = "*txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.Filter = "Arquivo de Texto (*.txt)|*.txt|" + "Todos os Arquivos (*.*)|*.*|" + "Documento (*.docx)|*.docx";
            DialogResult dialogResult = saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName.Length != 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Text = "Novo arquivo - SISTEMA DE CADASTRO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Procurar Documento";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Arquivo de Texto (*.txt)|*.txt|" + "Todos os Arquivos (*.*)|*.*|" + "Documento (*.docx)|*.docx";
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            try
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                richTextBox1.Text = "";

                string linha = streamReader.ReadLine();

                while (linha != null)
                {
                    richTextBox1.Text += linha + "\n";
                    linha = streamReader.ReadLine();
                }
                Text = openFileDialog1.FileName + " - Sistema de cadastro";
                CaminhoDocumento = openFileDialog1.FileName;
                streamReader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERRO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banco.ObterTodosJogadores();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globais.logado = false;
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Globais.logado = false;
        }

        private void adicionarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

                if (Globais.nivel >= 2)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

                if (Globais.nivel >= 1)
                {
                    NovoJogador novoJogador = new NovoJogador();
                    novoJogador.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
        }

        private void gestorDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

                if (Globais.nivel >= 2)
                {
                    F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                    f_GestaoUsuarios.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banco.ObterTodosJogadores();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
