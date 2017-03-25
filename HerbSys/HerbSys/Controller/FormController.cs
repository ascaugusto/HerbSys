using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerbSys.VIEW
{
    class FormController
    {
        public void callFormCadastraCliente()
        {
            frmCadastroCliente formcadastrocliente = new frmCadastroCliente();
            formcadastrocliente.Show();
        }

        public void callFormCadastraProduto()
        {
            MessageBox.Show("Página em manutenção!", "Manutenção",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void callRegistraVenda()
        {
            MessageBox.Show("Página em manutenção!", "Manutenção",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

    }
}
