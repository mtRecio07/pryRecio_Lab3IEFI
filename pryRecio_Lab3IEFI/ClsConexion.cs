using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pryRecio_Lab3IEFI
{
    public class ClsConexion
    {
        // Conexión pública para acceder desde otras clases o formularios
        public OleDbConnection Conexion { get; private set; }

        // Constructor que inicializa la conexión
        public ClsConexion()
        {
            // Asegúrate de que la ruta y el nombre del archivo MDB/ACCDB sean correctos
            string cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBUsuarios.mdb";
            Conexion = new OleDbConnection(cadenaConexion);
        }

        // Método para abrir la conexión
        public void Abrir()
        {
            if (Conexion.State != System.Data.ConnectionState.Open)
            {
                Conexion.Open();
            }
        }

        // Método para cerrar la conexión
        public void Cerrar()
        {
            if (Conexion.State != System.Data.ConnectionState.Closed)
            {
                Conexion.Close();
            }
        }
    }
}
