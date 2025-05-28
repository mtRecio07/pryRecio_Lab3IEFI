namespace pryRecio_Lab3IEFI
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.linkLblRegistrar = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(458, 159);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(318, 25);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(458, 218);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(318, 25);
            this.txtContraseña.TabIndex = 2;
            // 
            // linkLblRegistrar
            // 
            this.linkLblRegistrar.AutoSize = true;
            this.linkLblRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblRegistrar.Location = new System.Drawing.Point(455, 333);
            this.linkLblRegistrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLblRegistrar.Name = "linkLblRegistrar";
            this.linkLblRegistrar.Size = new System.Drawing.Size(281, 17);
            this.linkLblRegistrar.TabIndex = 4;
            this.linkLblRegistrar.TabStop = true;
            this.linkLblRegistrar.Text = "¿Todavía no tienes una cuenta? Registrate";
            this.linkLblRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegistrar_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = global::pryRecio_Lab3IEFI.Properties.Resources.Prototipo_de_Ordenador_Inicio_Sesión_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(522, 259);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryRecio_Lab3IEFI.Properties.Resources.Prototipo_de_Ordenador_Inicio_Sesión_Web_Ilustrado_Ordenado_Azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLblRegistrar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInicio";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.LinkLabel linkLblRegistrar;
        private System.Windows.Forms.Button button1;
    }
}

