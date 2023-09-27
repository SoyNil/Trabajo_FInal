using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Inicio_Sesion
{
    internal class Conexión
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-C0BT61P;DATABASE=LOGIN;Integrated security=true");

            cn.Open();
            return cn;

        }
    }
}
