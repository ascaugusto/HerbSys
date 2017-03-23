using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerbSys
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void stbCadastrarProduto_Click(object sender, EventArgs e)
        {

        }

        private void tsbCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente formcadastrocliente = new frmCadastroCliente();
            formcadastrocliente.Show();

        }
    }
}
