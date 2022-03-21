namespace BRAIDA_CRESSA_JOAQUIN_LEONEL___21_NMS
{
    partial class fmcarga
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboprovincia = new System.Windows.Forms.ComboBox();
            this.txtmesa = new System.Windows.Forms.TextBox();
            this.txtparta = new System.Windows.Forms.TextBox();
            this.txtpartb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partido A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Partido B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provincia";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(248, 278);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(161, 48);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(60, 278);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(161, 48);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cboprovincia
            // 
            this.cboprovincia.FormattingEnabled = true;
            this.cboprovincia.Items.AddRange(new object[] {
            "Seleccionar",
            "Cordoba",
            "Buenos Aires"});
            this.cboprovincia.Location = new System.Drawing.Point(179, 217);
            this.cboprovincia.Name = "cboprovincia";
            this.cboprovincia.Size = new System.Drawing.Size(239, 24);
            this.cboprovincia.TabIndex = 6;
            // 
            // txtmesa
            // 
            this.txtmesa.Location = new System.Drawing.Point(179, 32);
            this.txtmesa.Name = "txtmesa";
            this.txtmesa.Size = new System.Drawing.Size(239, 22);
            this.txtmesa.TabIndex = 7;
            // 
            // txtparta
            // 
            this.txtparta.Location = new System.Drawing.Point(179, 102);
            this.txtparta.Name = "txtparta";
            this.txtparta.Size = new System.Drawing.Size(239, 22);
            this.txtparta.TabIndex = 8;
            // 
            // txtpartb
            // 
            this.txtpartb.Location = new System.Drawing.Point(179, 161);
            this.txtpartb.Name = "txtpartb";
            this.txtpartb.Size = new System.Drawing.Size(239, 22);
            this.txtpartb.TabIndex = 9;
            // 
            // fmcarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 466);
            this.Controls.Add(this.txtpartb);
            this.Controls.Add(this.txtparta);
            this.Controls.Add(this.txtmesa);
            this.Controls.Add(this.cboprovincia);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmcarga";
            this.Text = "CARGA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cboprovincia;
        private System.Windows.Forms.TextBox txtmesa;
        private System.Windows.Forms.TextBox txtparta;
        private System.Windows.Forms.TextBox txtpartb;
    }
}