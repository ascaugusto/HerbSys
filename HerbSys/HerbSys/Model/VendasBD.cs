using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HerbSys.Model
{
    class VendasBD
    {   

        
        public struct DadosVenda
        {
            public string cpf_cnpj;
            public string valor_total;
        }

        public int inserir(DadosVenda dadosVenda)
        {
            int SQLiteReturn;
            DadosVenda dados = new DadosVenda();
            dados = dadosVenda;
                
            String insSQL = "INSERT INTO VENDAS (CPF_CNPJ_CLIENTE,ID_PRODUTOS_VENDA,VALOR_TOTAL)" + " VALUES('" + dados.cpf_cnpj + "','" + dados.valor_total + "')";
            String strConn = @"Data Source=C:\dados\HerbSysSqLite.db";

            SQLiteConnection connection = new SQLiteConnection(strConn);

            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(insSQL, connection);
            SQLiteReturn = cmd.ExecuteNonQuery();
                        

            connection.Close();
            
            return SQLiteReturn;
        }

    }
}
