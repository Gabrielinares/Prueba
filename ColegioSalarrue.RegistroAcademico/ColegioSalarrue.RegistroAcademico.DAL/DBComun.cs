using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioSalarrue.RegistroAcademico.DAL
{
    public class DBComun
    {
        public const string _cadenaConexion = @"Data Source=DESKTOP-GFF2SSM\SQLEXPRESS01;Initial Catalog=CS_REGISTRO;Integrated Security=True";


        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
    }
}
