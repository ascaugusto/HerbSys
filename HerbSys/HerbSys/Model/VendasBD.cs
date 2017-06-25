using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbSys.Model
{
    class VendasBD
    {
        public class Venda
        {
            public int Id_vendas { get; set; }
            public float Cpf_cnpj_cliente { get; set; }
            //public List<ProdutoBD.Produto> Produtos_venda { get; set; }
            
        }
    }
}
