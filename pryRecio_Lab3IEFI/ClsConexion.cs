using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pryRecio_Lab3IEFI
{
    public class ClsConexion : System.IDisposable
    {

        public OleDbConnection Conexion { get; private set; }


        public ClsConexion()
        {

            string cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBUsuarios.mdb";
            Conexion = new OleDbConnection(cadenaConexion);
        }


        public void Abrir()
        {

            if (Conexion.State != System.Data.ConnectionState.Open)

                Conexion.Open();

        }


        public void Cerrar()


        {
            if (Conexion.State != System.Data.ConnectionState.Closed)
                Conexion.Close();
        }

        public void Dispose()
        {
            if (Conexion != null)
            {
                if (Conexion.State != System.Data.ConnectionState.Closed)
                    Conexion.Close();

                Conexion.Dispose();
                Conexion = null;
            }
        }
    }

}
