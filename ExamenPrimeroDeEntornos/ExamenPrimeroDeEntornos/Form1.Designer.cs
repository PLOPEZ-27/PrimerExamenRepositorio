namespace ExamenPrimeroDeEntornos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cbmVehiculo = new System.Windows.Forms.ComboBox();
            this.btnVerResumen = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbRespuestaNombre = new System.Windows.Forms.Label();
            this.lbRespuestaDni = new System.Windows.Forms.Label();
            this.lbRespuestaTelefono = new System.Windows.Forms.Label();
            this.lbRespuestaVehiculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTORENT HN";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(117, 89);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(80, 28);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dni/Identidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de vehiculo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(240, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(272, 140);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(220, 22);
            this.txtIdentidad.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(230, 186);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // cbmVehiculo
            // 
            this.cbmVehiculo.FormattingEnabled = true;
            this.cbmVehiculo.Items.AddRange(new object[] {
            "1. Turismos",
            "2. SUV",
            "3. Pickup"});
            this.cbmVehiculo.Location = new System.Drawing.Point(311, 237);
            this.cbmVehiculo.Name = "cbmVehiculo";
            this.cbmVehiculo.Size = new System.Drawing.Size(160, 24);
            this.cbmVehiculo.TabIndex = 8;
            // 
            // btnVerResumen
            // 
            this.btnVerResumen.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerResumen.Location = new System.Drawing.Point(135, 305);
            this.btnVerResumen.Name = "btnVerResumen";
            this.btnVerResumen.Size = new System.Drawing.Size(119, 45);
            this.btnVerResumen.TabIndex = 9;
            this.btnVerResumen.Text = "Avanzar";
            this.btnVerResumen.UseVisualStyleBackColor = true;
            this.btnVerResumen.Click += new System.EventHandler(this.btnVerResumen_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(272, 305);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 45);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(416, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 45);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamenPrimeroDeEntornos.Properties.Resources.imagen_autorentcar;
            this.pictureBox1.Location = new System.Drawing.Point(111, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "DATOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dni:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(633, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(633, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Vehiculo:";
            // 
            // lbRespuestaNombre
            // 
            this.lbRespuestaNombre.AutoSize = true;
            this.lbRespuestaNombre.Location = new System.Drawing.Point(726, 89);
            this.lbRespuestaNombre.Name = "lbRespuestaNombre";
            this.lbRespuestaNombre.Size = new System.Drawing.Size(0, 16);
            this.lbRespuestaNombre.TabIndex = 18;
            // 
            // lbRespuestaDni
            // 
            this.lbRespuestaDni.AutoSize = true;
            this.lbRespuestaDni.Location = new System.Drawing.Point(690, 147);
            this.lbRespuestaDni.Name = "lbRespuestaDni";
            this.lbRespuestaDni.Size = new System.Drawing.Size(0, 16);
            this.lbRespuestaDni.TabIndex = 19;
            // 
            // lbRespuestaTelefono
            // 
            this.lbRespuestaTelefono.AutoSize = true;
            this.lbRespuestaTelefono.Location = new System.Drawing.Point(729, 197);
            this.lbRespuestaTelefono.Name = "lbRespuestaTelefono";
            this.lbRespuestaTelefono.Size = new System.Drawing.Size(0, 16);
            this.lbRespuestaTelefono.TabIndex = 20;
            // 
            // lbRespuestaVehiculo
            // 
            this.lbRespuestaVehiculo.AutoSize = true;
            this.lbRespuestaVehiculo.Location = new System.Drawing.Point(729, 244);
            this.lbRespuestaVehiculo.Name = "lbRespuestaVehiculo";
            this.lbRespuestaVehiculo.Size = new System.Drawing.Size(0, 16);
            this.lbRespuestaVehiculo.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 581);
            this.Controls.Add(this.lbRespuestaVehiculo);
            this.Controls.Add(this.lbRespuestaTelefono);
            this.Controls.Add(this.lbRespuestaDni);
            this.Controls.Add(this.lbRespuestaNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVerResumen);
            this.Controls.Add(this.cbmVehiculo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cbmVehiculo;
        private System.Windows.Forms.Button btnVerResumen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRespuestaNombre;
        private System.Windows.Forms.Label lbRespuestaDni;
        private System.Windows.Forms.Label lbRespuestaTelefono;
        private System.Windows.Forms.Label lbRespuestaVehiculo;
    }
}

