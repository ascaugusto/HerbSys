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
        public void CallFormCadastraCliente()
        {
            frmCadastroCliente formcadastrocliente = new frmCadastroCliente();
            formcadastrocliente.Show();
        }

        public void CallFormCadastraProduto()
        {
            MessageBox.Show("Página em manutenção!", "Manutenção",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void CallRegistraVenda()
        {
            MessageBox.Show("Página em manutenção!", "Manutenção",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

    }
}
