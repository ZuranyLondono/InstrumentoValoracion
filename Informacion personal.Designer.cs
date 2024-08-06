namespace Instrumento_de_Valoracion__de_la_familia
{
    partial class Informacion_personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacion_personal));
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSegundoA = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtsegundoapellido = new System.Windows.Forms.TextBox();
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.txtSegundonombre = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMunicipo = new System.Windows.Forms.Label();
            this.txtmunicipio = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(420, 34);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(418, 46);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "Informacion Personal";
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(154, 114);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(169, 20);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Datos del Paciente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(158, 174);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Primer Nombre";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(683, 174);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(114, 16);
            this.lblSegundo.TabIndex = 3;
            this.lblSegundo.Text = "Segundo Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(158, 252);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(99, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Primer Apellido";
            // 
            // lblSegundoA
            // 
            this.lblSegundoA.AutoSize = true;
            this.lblSegundoA.Location = new System.Drawing.Point(683, 252);
            this.lblSegundoA.Name = "lblSegundoA";
            this.lblSegundoA.Size = new System.Drawing.Size(115, 16);
            this.lblSegundoA.TabIndex = 5;
            this.lblSegundoA.Text = "Segundo Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(289, 174);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 22);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtsegundoapellido
            // 
            this.txtsegundoapellido.Location = new System.Drawing.Point(845, 261);
            this.txtsegundoapellido.Name = "txtsegundoapellido";
            this.txtsegundoapellido.Size = new System.Drawing.Size(198, 22);
            this.txtsegundoapellido.TabIndex = 7;
            this.txtsegundoapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoapellido_KeyPress);
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Location = new System.Drawing.Point(289, 261);
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(198, 22);
            this.txtprimerapellido.TabIndex = 8;
            this.txtprimerapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerapellido_KeyPress);
            // 
            // txtSegundonombre
            // 
            this.txtSegundonombre.Location = new System.Drawing.Point(845, 174);
            this.txtSegundonombre.Name = "txtSegundonombre";
            this.txtSegundonombre.Size = new System.Drawing.Size(198, 22);
            this.txtSegundonombre.TabIndex = 9;
            this.txtSegundonombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundonombre_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(161, 331);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(135, 16);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha de Nacimiento";
            // 
            // dtmFecha
            // 
            this.dtmFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFecha.Location = new System.Drawing.Point(349, 331);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(200, 22);
            this.dtmFecha.TabIndex = 11;
            this.dtmFecha.Value = new System.DateTime(2024, 7, 24, 0, 0, 0, 0);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(683, 331);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 16);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero";
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(845, 333);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(198, 22);
            this.txtgenero.TabIndex = 13;
            this.txtgenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgenero_KeyPress);
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidencia.Location = new System.Drawing.Point(154, 441);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(184, 20);
            this.lblResidencia.TabIndex = 14;
            this.lblResidencia.Text = "Datos de Residencia";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(158, 533);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(93, 16);
            this.lblDepartamento.TabIndex = 15;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(158, 610);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblMunicipo
            // 
            this.lblMunicipo.AutoSize = true;
            this.lblMunicipo.Location = new System.Drawing.Point(683, 533);
            this.lblMunicipo.Name = "lblMunicipo";
            this.lblMunicipo.Size = new System.Drawing.Size(64, 16);
            this.lblMunicipo.TabIndex = 17;
            this.lblMunicipo.Text = "Municipio";
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.Location = new System.Drawing.Point(845, 533);
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(198, 22);
            this.txtmunicipio.TabIndex = 18;
            this.txtmunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmunicipio_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(289, 604);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(198, 22);
            this.txtdireccion.TabIndex = 19;
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.Location = new System.Drawing.Point(289, 533);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(198, 22);
            this.txtdepartamento.TabIndex = 20;
            this.txtdepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdepartamento_KeyPress);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(1076, 650);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(112, 29);
            this.btnSiguiente.TabIndex = 21;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Informacion_personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1226, 720);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtmunicipio);
            this.Controls.Add(this.lblMunicipo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblResidencia);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.dtmFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtSegundonombre);
            this.Controls.Add(this.txtprimerapellido);
            this.Controls.Add(this.txtsegundoapellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSegundoA);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblInformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informacion_personal";
            this.Text = "Informacion_personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSegundoA;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtsegundoapellido;
        private System.Windows.Forms.TextBox txtprimerapellido;
        private System.Windows.Forms.TextBox txtSegundonombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMunicipo;
        private System.Windows.Forms.TextBox txtmunicipio;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.Button btnSiguiente;
    }
}