using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerbSys.Model;

namespace HerbSys.Controller
{
    class DataController
    {
        public int InserirCliente(ClienteBD.DadosCliente dadosCliente) {

            ClienteBD cliente = new ClienteBD();
            int insRetorno;
            insRetorno = cliente.Inserir(dadosCliente);
            return insRetorno;

        }

        public void RemoverCliente() {
            
        }

        public void AlterarCliente() {

        }

        public int InserirVenda(VendasBD.DadosVenda dadosVendas)
        {
            VendasBD vendas = new VendasBD();
            int insRetorno;
            insRetorno = vendas.inserir(dadosVendas);
            return insRetorno;

        }

    }
}
