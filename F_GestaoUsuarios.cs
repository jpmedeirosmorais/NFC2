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
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banco.ObterUsuariosIdNome();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
