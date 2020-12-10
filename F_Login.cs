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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string senha = textBox2.Text;

            if(username == "" || senha == "")
            {
                MessageBox.Show("Usuário e/ou senha inválidos!");
                textBox1.Focus();
                
                Globais.logado = false;
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME = '"+username+"' AND T_SENHAUSUARIO = '"+senha+"'";
            dt = Banco.consulta(sql);
            
            if (dt.Rows.Count == 1)
            {
                
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELDOUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {   

                MessageBox.Show("Usuário e/ou senha não encontrado!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Globais.logado = false;
        }
    }
}
