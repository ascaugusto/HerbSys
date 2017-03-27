using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace HerbSys.Model
{
    class ClienteBD
    {
        public struct DadosCliente{
            public string cpf_cnpj;
            public string nome;
            public string endereco;
            public string cep;
            public string bairro;
            public string cidade;
            public string uf;
            public string telefone;
         }
        
        public int Inserir(DadosCliente dadosCliente)
        {
            int SQLiteReturn;
            DadosCliente dados = new DadosCliente();
            dados = dadosCliente;
                
            String insSQL = "INSERT INTO CLIENTE (CPF_CNPJ,NOME,ENDERECO,CEP,BAIRRO,CIDADE,UF,TELEFONE)" +" VALUES('"+ dados.cpf_cnpj + "','"+ dados.nome + "','"+ dados.endereco + "','"+ dados.cep + "','"+ dados.bairro + "','"+ dados.cidade + "','"+ dados.uf + "','"+ dados .telefone+ "')";
            String strConn = @"Data Source=C:\dados\HerbSysSqLite.db";
                                                        
            SQLiteConnection connection = new SQLiteConnection(strConn);

            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(insSQL, connection);
            SQLiteReturn = cmd.ExecuteNonQuery();
            connection.Close();
            
            return SQLiteReturn;
        }

        public void Remover()
        {

        }

        public void Alterar()
        {

        }
    }
}
