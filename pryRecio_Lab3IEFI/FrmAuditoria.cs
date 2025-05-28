using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace pryRecio_Lab3IEFI
{
    public partial class FrmAuditoria : Form
    {
        public FrmAuditoria()
        {
            InitializeComponent();
        }


        ClsConexion BDConexion = new ClsConexion();

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsConexion BDConexion = new ClsConexion())
                {
                    BDConexion.Abrir();

                    string consulta = @"
                SELECT U.Usuario, A.FechaHoraInicio, A.FechaHoraFin, A.Duracion
                FROM Auditoria A
                INNER JOIN Usuario U ON A.IdUsuario = U.IdUsuario";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, BDConexion.Conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvAuditoria.DataSource = tabla;

                    BDConexion.Cerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditoría: " + ex.Message);
            }

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuAdmin fp = new FrmMenuAdmin();
            fp.Show();
            this.Hide();
        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            

        }
    }
}
