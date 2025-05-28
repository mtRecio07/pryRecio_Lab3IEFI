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
    }
}
