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
    public partial class frmConfirmarCodigo : Form
    {
        public frmConfirmarCodigo()
        {
            InitializeComponent();
        }


        private string codigoOriginal;
        private string usuario;
        private string contraseña;


        ClsConexion BDConexion = new ClsConexion();


        public frmConfirmarCodigo(string codigo, string usuario, string contraseña)
        {
            InitializeComponent();
            codigoOriginal = codigo;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == codigoOriginal)
            {
                try
                {
                    BDConexion.Abrir();

                    string query = "INSERT INTO Usuario (Usuario, Contraseña, IdRol) VALUES (?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, BDConexion.Conexion);
                    cmd.Parameters.AddWithValue("?", usuario);
                    cmd.Parameters.AddWithValue("?", contraseña);
                    cmd.Parameters.AddWithValue("?", 2); // ID Rol por defecto

                    cmd.ExecuteNonQuery();
                    BDConexion.Cerrar();

                    MessageBox.Show("¡Usuario registrado correctamente!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    BDConexion.Cerrar();
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Código incorrecto.");
            }
        }
    }
}
