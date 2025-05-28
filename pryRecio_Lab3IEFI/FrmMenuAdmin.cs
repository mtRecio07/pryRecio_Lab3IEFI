using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRecio_Lab3IEFI
{
    public partial class FrmMenuAdmin : Form
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAuditoria auditoria = new FrmAuditoria();
            auditoria.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInicio login = new FrmInicio();
            login.Show();
            this.Close();
        }

        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosProgramador datosProgramador = new FrmDatosProgramador();
            datosProgramador.Show();
            
        }


        private void RegistrarAuditoria(int idUsuario, DateTime inicio, DateTime fin)
        {
            TimeSpan duracion = fin - inicio;
            int duracionEnSegundos = (int)duracion.TotalSeconds;

            string query = "INSERT INTO Auditoria (IdUsuario, FechaHoraInicio, FechaHoraFin, Duracion) VALUES (?, ?, ?, ?)";

            using (ClsConexion objConexion = new ClsConexion())
            {
                objConexion.Abrir();
                using (OleDbCommand cmd = new OleDbCommand(query, objConexion.Conexion))
                {
                    cmd.Parameters.Add(new OleDbParameter("IdUsuario", OleDbType.Integer) { Value = idUsuario });
                    cmd.Parameters.Add(new OleDbParameter("FechaHoraInicio", OleDbType.Date) { Value = inicio });
                    cmd.Parameters.Add(new OleDbParameter("FechaHoraFin", OleDbType.Date) { Value = fin });
                    cmd.Parameters.Add(new OleDbParameter("Duracion", OleDbType.Integer) { Value = duracionEnSegundos });

                    cmd.ExecuteNonQuery();
                }
                objConexion.Cerrar();
            }
        }

    }
}
