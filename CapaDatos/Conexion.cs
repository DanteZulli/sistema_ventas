using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En esta capa los datos se van a guardar y la misma se va a encargar de acceder a los mismos

namespace CapaDatos
{
    class Conexion
    {
       // Clase de conexión: Guarda la cadena de conexión con la base de datos que hice en SQL server 14
       // Actualización. Cambié la cadena manual por un archivo de configuración que automáticamente conecta todo con el servidor LOCAL.
        public static string Cn = Properties.Settings.Default.cn;
    }
}
