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
            VIEW.FormController formController = new VIEW.FormController();
            formController.callFormCadastraProduto();
        }

        private void tsbCadastrarCliente_Click(object sender, EventArgs e)
        {
            VIEW.FormController formController = new VIEW.FormController();
            formController.callFormCadastraCliente();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tooltsbRegistraVenda_Click(object sender, EventArgs e)
        {
            VIEW.FormController formController = new VIEW.FormController();
            formController.callRegistraVenda();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
