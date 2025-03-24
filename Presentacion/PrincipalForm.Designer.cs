namespace Comprar_Vuelos
{
    partial class PrincipalForm
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
            this.cboPuntoPartida = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVuelos = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCRUDVuelos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboPuntoPartida
            // 
            this.cboPuntoPartida.FormattingEnabled = true;
            this.cboPuntoPartida.Location = new System.Drawing.Point(284, 123);
            this.cboPuntoPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPuntoPartida.Name = "cboPuntoPartida";
            this.cboPuntoPartida.Size = new System.Drawing.Size(180, 28);
            this.cboPuntoPartida.TabIndex = 0;
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(284, 246);
            this.cboDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(180, 28);
            this.cboDestino.TabIndex = 1;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(92, 128);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(127, 20);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Punto de Partida";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(117, 246);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(64, 20);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(716, 138);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dtpFechaVuelos
            // 
            this.dtpFechaVuelos.AutoSize = true;
            this.dtpFechaVuelos.Location = new System.Drawing.Point(573, 138);
            this.dtpFechaVuelos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dtpFechaVuelos.Name = "dtpFechaVuelos";
            this.dtpFechaVuelos.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaVuelos.TabIndex = 5;
            this.dtpFechaVuelos.Text = "Fecha vuelos ";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(722, 268);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(112, 35);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "RESERVAR ";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCRUDVuelos
            // 
            this.btnCRUDVuelos.Location = new System.Drawing.Point(526, 323);
            this.btnCRUDVuelos.Name = "btnCRUDVuelos";
            this.btnCRUDVuelos.Size = new System.Drawing.Size(169, 41);
            this.btnCRUDVuelos.TabIndex = 7;
            this.btnCRUDVuelos.Text = "Gestionar vuelos";
            this.btnCRUDVuelos.UseVisualStyleBackColor = true;
            this.btnCRUDVuelos.Click += new System.EventHandler(this.btnCRUDVuelos_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnCRUDVuelos);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpFechaVuelos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboPuntoPartida);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrincipalForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPuntoPartida;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dtpFechaVuelos;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCRUDVuelos;
    }
}

