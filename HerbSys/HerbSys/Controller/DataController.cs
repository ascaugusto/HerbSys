using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerbSys.Model;
using System.Data.Entity;



namespace HerbSys.Controller
{
    class DataController
    {
        public int InserirCliente(ClienteDB.Cliente dadosCliente)
        {
            int slqRtn;
            try
            {
                using (var db = new ClienteDB.ClienteDBContext())
                {
                    db.Clientes.Add(dadosCliente);
                    slqRtn = db.SaveChanges();
                }
            }
            catch ( SystemException ex)
            {
                
            }
            return slqRtn;
        }
        public void RemoverCliente()
        {

        }

        public void AlterarCliente()
        {

        }
    }
}
