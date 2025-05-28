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
    public partial class FrmMenuOperador : Form
    {
        public FrmMenuOperador()
        {
            InitializeComponent();
        }

        private int idUsuario;
        private DateTime fechaHoraInicio;
        private string nombreUsuario;

        private Timer timerSesion;


        public FrmMenuOperador(int idUsuario, DateTime fechaHoraInicio, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.fechaHoraInicio = fechaHoraInicio;
            this.nombreUsuario = nombreUsuario;

            // Mostrar usuario
            lblUsuario.Text = "Usuario: " + nombreUsuario;

            // Inicializar Timer
            timerSesion = new Timer();
            timerSesion.Interval = 1000; // 1 segundo
            timerSesion.Tick += TimerSesion_Tick;
            timerSesion.Start();
        }


        private void TimerSesion_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoActivo = DateTime.Now - fechaHoraInicio;
            lblTiempo.Text = "Tiempo activo: " + tiempoActivo.ToString(@"hh\:mm\:ss");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime fechaHoraFin = DateTime.Now;
            TimeSpan duracion = fechaHoraFin - fechaHoraInicio;

            // Registrar en la base de datos
            ClsConexion objConexion = new ClsConexion();
            string query = "INSERT INTO Auditoria (IdUsuario, FechaHoraInicio, FechaHoraFin, Duracion) VALUES (?, ?, ?, ?)";

            using (OleDbCommand cmd = new OleDbCommand(query, objConexion.Conexion))
            {
                cmd.Parameters.AddWithValue("?", idUsuario);
                cmd.Parameters.AddWithValue("?", fechaHoraInicio);
                cmd.Parameters.AddWithValue("?", fechaHoraFin);
                string duracionFormateada = duracion.ToString(@"hh\:mm\:ss");
                cmd.Parameters.AddWithValue("?", duracionFormateada);
                objConexion.Abrir();
                cmd.ExecuteNonQuery();
                objConexion.Cerrar();
            }

            MessageBox.Show("Sesión cerrada correctamente.");
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
            this.Close();
        }

        private void FrmMenuOperador_Load(object sender, EventArgs e)
        {
            timerSesion.Start();
        }
    }
}
