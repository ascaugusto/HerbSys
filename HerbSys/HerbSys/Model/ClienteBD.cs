using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;

namespace HerbSys.Model
{
    class ClienteDB
    {
        public class Cliente
        {
            public string Cpf_cnpj { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Cep { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Uf { get; set; }
            public string Telefone { get; set; }
        }
                        
        public class ClienteDBContext : DbContext
        {
            public DbSet<Cliente> Clientes { get; set; }
        }
                
    }
}
