using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRecio_Lab3IEFI
{
    public partial class FrmDatosProgramador : Form
    {
        public FrmDatosProgramador()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblCorreo.Text = "correo@ejemplo.com";
            lblNombre.Text = "Nombre: Juan";
            lblApellido.Text = "Apellido: Pérez";
            lblMateria.Text = "Materia: Programación I";
            lblCarrera.Text = "Carrera: Ingeniería en Sistemas";

            // Cargar imagen en el PictureBox
            pictureBoxFoto.Image = Image.FromFile(@"E:\Escritorio\WhatsAppImage2025-05-28at10.29.30AM.jpeg");
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuAdmin menuAdmin = new FrmMenuAdmin();
            menuAdmin.Show();
            this.Close();
        }
    }
}
