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
using System.Net.Mail;
using System.Net;

namespace pryRecio_Lab3IEFI
{
    public partial class FrmRegistrarNuevoUsuario : Form
    {
        public FrmRegistrarNuevoUsuario()
        {
            InitializeComponent();
        }


        ClsConexion BDConexion = new ClsConexion(); // instancia global



        private string codigoGenerado = "";



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (correo == "" || usuario == "" || contraseña == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Generar código de verificación de 6 dígitos
            Random rnd = new Random();
            codigoGenerado = rnd.Next(100000, 999999).ToString();

            // Enviar correo
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("paulorecio81@gmail.com");
                mensaje.To.Add(correo);
                mensaje.Subject = "Código de verificación";
                mensaje.Body = $"Hola {usuario}, tu código de verificación es: {codigoGenerado}";

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.Credentials = new NetworkCredential("paulorecio81@gmail.com", "rftgyrvxpzobfxfx");
                cliente.EnableSsl = true;

                cliente.Send(mensaje);
                MessageBox.Show("Código enviado. Revisa tu correo.");

                // Mostrar formulario de confirmación
                frmConfirmarCodigo form = new frmConfirmarCodigo(codigoGenerado, usuario, contraseña);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInicio login = new FrmInicio();
            login.Show();
            this.Close();

        }
    }
}
