using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login_Biblioteca
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-0GVEA4G;DATABASE = Biblioteca;Integrated security=true");
            cn.Open();

            return cn;
        }
    }
}
