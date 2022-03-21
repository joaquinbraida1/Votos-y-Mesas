namespace BRAIDA_CRESSA_JOAQUIN_LEONEL___21_NMS
{
    partial class fmlistado
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
            this.dgvlistadovotos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadovotos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistadovotos
            // 
            this.dgvlistadovotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistadovotos.Location = new System.Drawing.Point(12, 12);
            this.dgvlistadovotos.Name = "dgvlistadovotos";
            this.dgvlistadovotos.RowTemplate.Height = 24;
            this.dgvlistadovotos.Size = new System.Drawing.Size(1080, 459);
            this.dgvlistadovotos.TabIndex = 0;
            // 
            // fmlistado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 484);
            this.Controls.Add(this.dgvlistadovotos);
            this.Name = "fmlistado";
            this.Text = "LISTADO";
            this.Load += new System.EventHandler(this.fmlistado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadovotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistadovotos;
    }
}