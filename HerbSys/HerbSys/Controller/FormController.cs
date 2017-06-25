using HerbSys.View;
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
            FormCadastraProdutos formCadastraproduto = new FormCadastraProdutos();
            formCadastraproduto.Show();
        }

        public void CallRegistraVenda()
        {
            FormRegistraVenda formRegistraVenda = new FormRegistraVenda();
            formRegistraVenda.Show();
                        
        }

    }
}
