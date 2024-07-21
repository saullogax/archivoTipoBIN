namespace pjSerializacionTextoMemo
{
    partial class frmSerializa
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerializar
            // 
            this.btnSerializar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializar.Location = new System.Drawing.Point(14, 211);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(149, 41);
            this.btnSerializar.TabIndex = 0;
            this.btnSerializar.Text = "SERIALIZAR";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserializar.Location = new System.Drawing.Point(169, 212);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Size = new System.Drawing.Size(149, 41);
            this.btnDeserializar.TabIndex = 1;
            this.btnDeserializar.Text = "DESERIALIZAR";
            this.btnDeserializar.UseVisualStyleBackColor = true;
            this.btnDeserializar.Click += new System.EventHandler(this.btnDeserializar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(455, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(14, 12);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(567, 191);
            this.txtCadena.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(324, 213);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 40);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmSerializa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 264);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeserializar);
            this.Controls.Add(this.btnSerializar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSerializa";
            this.Text = "SERIALIZADOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnDeserializar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

