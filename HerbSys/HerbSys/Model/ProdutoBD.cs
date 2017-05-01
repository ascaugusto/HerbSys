using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace HerbSys.Model
{
    class ProdutoBD
    {
        public class Produto
        {
         public int Id_produto { get; set; }   
         public string Nom_produto { get; set; }
         public decimal Valor { get; set; }
        }

        public class ProdutoDBContext : DbContext
        {
            public DbSet<Produto> Produtos { get; set; }
        }

    }
}
