using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login_Biblioteca
{
    class Usuarios
    { public static int CrearCuentas(string pNombre, string pApellido, string pFechaNac, string pDNI, string pEmail, string pNombreUsu, string pContraseña, string pContraConf)
        {
            int resultado = 0;
            SqlConnection cn = Conexion.Conectar();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuarios (Nombre, Apellido, FechaNac, DNI, Email, NombreUsu, Contraseña, ContraConf) values ('{0}', '{0}', '{0}', '{0}', '{0}', '{0}', PwdEncrypt('{1}'), PwdEncrypt('{1}'))", pNombre, pApellido, pFechaNac, pDNI, pEmail, pNombreUsu, pContraseña, pContraConf), cn);
            resultado = Comando.ExecuteNonQuery();
            cn.Close();
            return resultado;
                
        }
    }
}
