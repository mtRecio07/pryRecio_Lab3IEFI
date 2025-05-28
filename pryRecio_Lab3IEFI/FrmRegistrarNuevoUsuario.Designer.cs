namespace pryRecio_Lab3IEFI
{
    partial class FrmRegistrarNuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCorreo.Location = new System.Drawing.Point(459, 162);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(318, 23);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.Text = "Correo electronico";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(459, 221);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(318, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Nombre de usuario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.BackgroundImage = global::pryRecio_Lab3IEFI.Properties.Resources.Prototipo_de_Ordenador_Inicio_Sesión_1;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(526, 329);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(190, 49);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContraseña.Location = new System.Drawing.Point(459, 280);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(318, 23);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.Text = "Contraseña";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // FrmRegistrarNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryRecio_Lab3IEFI.Properties.Resources.Prototipo_de_Ordenador_Inicio_Sesión_Web_Ilustrado_Ordenado_Azul__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 453);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRegistrarNuevoUsuario";
            this.Text = "Registrarse";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
    }
}