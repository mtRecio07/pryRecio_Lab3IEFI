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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }


        ClsConexion BDConexion = new ClsConexion();
        

        private DateTime horaInicio;
        private int idUsuario;


        private void linkLblRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrarNuevoUsuario fp = new FrmRegistrarNuevoUsuario();
            fp.Show();
            this.Hide();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            ClsConexion conexion = new ClsConexion();
            conexion.Abrir();

            string consulta = "SELECT IdUsuario, IdRol FROM Usuario WHERE Usuario = ? AND Contraseña = ?";
            OleDbCommand cmd = new OleDbCommand(consulta, conexion.Conexion);
            cmd.Parameters.AddWithValue("?", usuario);
            cmd.Parameters.AddWithValue("?", contraseña);

            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                idUsuario = Convert.ToInt32(reader["IdUsuario"]);
                int idRol = Convert.ToInt32(reader["IdRol"]);

                // Guardar hora de inicio
                horaInicio = DateTime.Now;

                if (idRol == 1)
                {
                    // Administrador
                    FrmMenuAdmin admin = new FrmMenuAdmin();
                    admin.Show();
                }
                else if (idRol == 2)
                {
                    // Operador
                    string nombreUsuario = reader["Usuario"].ToString();
                    FrmMenuOperador operador = new FrmMenuOperador(idUsuario, horaInicio, nombreUsuario);
                    operador.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            conexion.Cerrar();
        }
    }
}
