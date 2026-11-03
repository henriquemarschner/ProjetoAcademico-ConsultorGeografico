using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises.Classes
{
    internal class Banco
    {
        private static string strcnn = @"Data Source=localhost;Initial Catalog=ConsultaPaises;Integrated Security=True";

        public static SqlConnection AbrirDB()
        {
            SqlConnection cnn = new SqlConnection(strcnn);
            cnn.Open();
            return cnn;
        }
    }
}
