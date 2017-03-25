using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerbSys.VIEW;

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
            FormController formController = new FormController();
            formController.callFormCadastraProduto();
        }

        private void tsbCadastrarCliente_Click(object sender, EventArgs e)
        {
			FormController formController = new FormController();
            formController.callFormCadastraCliente();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tooltsbRegistraVenda_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.callRegistraVenda();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
