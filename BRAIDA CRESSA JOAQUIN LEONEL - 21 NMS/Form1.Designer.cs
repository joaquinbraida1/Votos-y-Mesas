namespace BRAIDA_CRESSA_JOAQUIN_LEONEL___21_NMS
{
    partial class MENU
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carga = new System.Windows.Forms.ToolStripMenuItem();
            this.listado = new System.Windows.Forms.ToolStripMenuItem();
            this.estadistica = new System.Windows.Forms.ToolStripMenuItem();
            this.MsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carga,
            this.listado,
            this.estadistica,
            this.MsSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carga
            // 
            this.carga.Name = "carga";
            this.carga.Size = new System.Drawing.Size(78, 24);
            this.carga.Text = "CARGAR";
            this.carga.Click += new System.EventHandler(this.fmcargar_Click);
            // 
            // listado
            // 
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(109, 24);
            this.listado.Text = "VER LISTADO";
            this.listado.Click += new System.EventHandler(this.listado_Click);
            // 
            // estadistica
            // 
            this.estadistica.Name = "estadistica";
            this.estadistica.Size = new System.Drawing.Size(108, 24);
            this.estadistica.Text = "ESTADISTICA";
            this.estadistica.Click += new System.EventHandler(this.estadistica_Click);
            // 
            // MsSalir
            // 
            this.MsSalir.Name = "MsSalir";
            this.MsSalir.Size = new System.Drawing.Size(59, 24);
            this.MsSalir.Text = "SALIR";
            this.MsSalir.Click += new System.EventHandler(this.MsSalir_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 425);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.Text = "MENU PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carga;
        private System.Windows.Forms.ToolStripMenuItem listado;
        private System.Windows.Forms.ToolStripMenuItem estadistica;
        private System.Windows.Forms.ToolStripMenuItem MsSalir;
    }
}

