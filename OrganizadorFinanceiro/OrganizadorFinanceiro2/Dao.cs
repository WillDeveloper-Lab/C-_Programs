using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrganizadorFinanceiro2
{
    class Dao
    {
        protected MySqlConnection conexao;
        public Dao()
        {
            Conecta();
        }
        public void Conecta()
        {
            try
            {
                conexao= new MySqlConnection("server=localhost;port=3307;User Id=root;database=moneyplus;password=usbw");
                conexao.Open();
                Console.WriteLine("Conexão criada:");
                conexao.Close();
            }
            catch
            {

            }
        }
    }
}
