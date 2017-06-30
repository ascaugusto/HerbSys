using HerbSys.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerbSys.View
{
    public partial class FormRegistraVenda : Form
    {
        public FormRegistraVenda()
        {
            InitializeComponent();
        }

        private void FormRegistraVenda_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClientes.Text = "09902630618";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendasBD.DadosVenda dados = new VendasBD.DadosVenda();
            dados.cpf_cnpj = cbClientes.Text;
            dados.valor_total = cbProdutos.Text;

        }

        private void cbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProdutos.Text = "1";
        }
    }
}
