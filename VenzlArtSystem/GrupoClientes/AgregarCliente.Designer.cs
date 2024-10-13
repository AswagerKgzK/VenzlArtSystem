/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 17/5/2023
 * Hora: 8:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class AgregarCliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
			this.LblAgregado = new System.Windows.Forms.Label();
			this.LblFijo = new System.Windows.Forms.Label();
			this.BotonBuscar = new System.Windows.Forms.Button();
			this.BotonCerrar = new System.Windows.Forms.Button();
			this.BotonAgregar_Actualizar = new System.Windows.Forms.Button();
			this.LblTelefonoP = new System.Windows.Forms.Label();
			this.TxtTelefonoP = new System.Windows.Forms.TextBox();
			this.LblFechaFabricacion = new System.Windows.Forms.Label();
			this.LblApellido = new System.Windows.Forms.Label();
			this.LblCorreo = new System.Windows.Forms.Label();
			this.TxtNacimiento = new System.Windows.Forms.MaskedTextBox();
			this.TxtApellido = new System.Windows.Forms.TextBox();
			this.TxtCorreo = new System.Windows.Forms.TextBox();
			this.TxtNombre = new System.Windows.Forms.TextBox();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.LblNombre = new System.Windows.Forms.Label();
			this.LblCedula = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTelefonoR = new System.Windows.Forms.TextBox();
			this.BotonReiniciar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblAgregado
			// 
			this.LblAgregado.AutoSize = true;
			this.LblAgregado.BackColor = System.Drawing.Color.Transparent;
			this.LblAgregado.ForeColor = System.Drawing.Color.White;
			this.LblAgregado.Location = new System.Drawing.Point(133, 7);
			this.LblAgregado.Name = "LblAgregado";
			this.LblAgregado.Size = new System.Drawing.Size(37, 13);
			this.LblAgregado.TabIndex = 38;
			this.LblAgregado.Text = "Fecha";
			this.LblAgregado.Visible = false;
			// 
			// LblFijo
			// 
			this.LblFijo.AutoSize = true;
			this.LblFijo.BackColor = System.Drawing.Color.Transparent;
			this.LblFijo.ForeColor = System.Drawing.Color.White;
			this.LblFijo.Location = new System.Drawing.Point(3, 7);
			this.LblFijo.Name = "LblFijo";
			this.LblFijo.Size = new System.Drawing.Size(126, 13);
			this.LblFijo.TabIndex = 37;
			this.LblFijo.Text = "Agregado a la agenda el:";
			this.LblFijo.Visible = false;
			// 
			// BotonBuscar
			// 
			this.BotonBuscar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonBuscar.FlatAppearance.BorderSize = 0;
			this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonBuscar.ForeColor = System.Drawing.Color.White;
			this.BotonBuscar.Location = new System.Drawing.Point(311, 63);
			this.BotonBuscar.Name = "BotonBuscar";
			this.BotonBuscar.Size = new System.Drawing.Size(70, 30);
			this.BotonBuscar.TabIndex = 32;
			this.BotonBuscar.Text = "Buscar";
			this.BotonBuscar.UseVisualStyleBackColor = false;
			this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscarClick);
			// 
			// BotonCerrar
			// 
			this.BotonCerrar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCerrar.FlatAppearance.BorderSize = 0;
			this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCerrar.ForeColor = System.Drawing.Color.White;
			this.BotonCerrar.Location = new System.Drawing.Point(429, 10);
			this.BotonCerrar.Name = "BotonCerrar";
			this.BotonCerrar.Size = new System.Drawing.Size(70, 30);
			this.BotonCerrar.TabIndex = 30;
			this.BotonCerrar.Text = "Cerrar";
			this.BotonCerrar.UseVisualStyleBackColor = false;
			this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrarClick);
			// 
			// BotonAgregar_Actualizar
			// 
			this.BotonAgregar_Actualizar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonAgregar_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonAgregar_Actualizar.FlatAppearance.BorderSize = 0;
			this.BotonAgregar_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonAgregar_Actualizar.ForeColor = System.Drawing.Color.White;
			this.BotonAgregar_Actualizar.Location = new System.Drawing.Point(429, 355);
			this.BotonAgregar_Actualizar.Name = "BotonAgregar_Actualizar";
			this.BotonAgregar_Actualizar.Size = new System.Drawing.Size(70, 40);
			this.BotonAgregar_Actualizar.TabIndex = 9;
			this.BotonAgregar_Actualizar.Text = "Agregar o Actualizar";
			this.BotonAgregar_Actualizar.UseVisualStyleBackColor = false;
			this.BotonAgregar_Actualizar.Click += new System.EventHandler(this.BotonAgregar_ActualizarClick);
			// 
			// LblTelefonoP
			// 
			this.LblTelefonoP.AutoSize = true;
			this.LblTelefonoP.BackColor = System.Drawing.Color.Transparent;
			this.LblTelefonoP.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTelefonoP.ForeColor = System.Drawing.Color.White;
			this.LblTelefonoP.Location = new System.Drawing.Point(34, 263);
			this.LblTelefonoP.Name = "LblTelefonoP";
			this.LblTelefonoP.Size = new System.Drawing.Size(137, 32);
			this.LblTelefonoP.TabIndex = 36;
			this.LblTelefonoP.Text = "Telefono Personal:";
			// 
			// TxtTelefonoP
			// 
			this.TxtTelefonoP.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTelefonoP.Location = new System.Drawing.Point(34, 303);
			this.TxtTelefonoP.MaxLength = 11;
			this.TxtTelefonoP.Name = "TxtTelefonoP";
			this.TxtTelefonoP.Size = new System.Drawing.Size(130, 29);
			this.TxtTelefonoP.TabIndex = 7;
			this.TxtTelefonoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoPKeyPress);
			// 
			// LblFechaFabricacion
			// 
			this.LblFechaFabricacion.AutoSize = true;
			this.LblFechaFabricacion.BackColor = System.Drawing.Color.Transparent;
			this.LblFechaFabricacion.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFechaFabricacion.ForeColor = System.Drawing.Color.White;
			this.LblFechaFabricacion.Location = new System.Drawing.Point(188, 320);
			this.LblFechaFabricacion.Name = "LblFechaFabricacion";
			this.LblFechaFabricacion.Size = new System.Drawing.Size(155, 32);
			this.LblFechaFabricacion.TabIndex = 35;
			this.LblFechaFabricacion.Text = "Fecha de nacimiento:";
			// 
			// LblApellido
			// 
			this.LblApellido.AutoSize = true;
			this.LblApellido.BackColor = System.Drawing.Color.Transparent;
			this.LblApellido.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblApellido.ForeColor = System.Drawing.Color.White;
			this.LblApellido.Location = new System.Drawing.Point(86, 150);
			this.LblApellido.Name = "LblApellido";
			this.LblApellido.Size = new System.Drawing.Size(75, 32);
			this.LblApellido.TabIndex = 33;
			this.LblApellido.Text = "Apellido:";
			// 
			// LblCorreo
			// 
			this.LblCorreo.AutoSize = true;
			this.LblCorreo.BackColor = System.Drawing.Color.Transparent;
			this.LblCorreo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCorreo.ForeColor = System.Drawing.Color.White;
			this.LblCorreo.Location = new System.Drawing.Point(57, 185);
			this.LblCorreo.Name = "LblCorreo";
			this.LblCorreo.Size = new System.Drawing.Size(66, 32);
			this.LblCorreo.TabIndex = 31;
			this.LblCorreo.Text = "Correo:";
			// 
			// TxtNacimiento
			// 
			this.TxtNacimiento.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNacimiento.Location = new System.Drawing.Point(212, 355);
			this.TxtNacimiento.Mask = "00/00/0000";
			this.TxtNacimiento.Name = "TxtNacimiento";
			this.TxtNacimiento.Size = new System.Drawing.Size(100, 29);
			this.TxtNacimiento.TabIndex = 6;
			this.TxtNacimiento.ValidatingType = typeof(System.DateTime);
			this.TxtNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNacimientoKeyPress);
			// 
			// TxtApellido
			// 
			this.TxtApellido.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtApellido.Location = new System.Drawing.Point(166, 150);
			this.TxtApellido.MaxLength = 35;
			this.TxtApellido.Name = "TxtApellido";
			this.TxtApellido.Size = new System.Drawing.Size(219, 29);
			this.TxtApellido.TabIndex = 3;
			this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoKeyPress);
			// 
			// TxtCorreo
			// 
			this.TxtCorreo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtCorreo.Location = new System.Drawing.Point(127, 185);
			this.TxtCorreo.MaxLength = 25;
			this.TxtCorreo.Name = "TxtCorreo";
			this.TxtCorreo.Size = new System.Drawing.Size(318, 29);
			this.TxtCorreo.TabIndex = 4;
			this.TxtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreoKeyPress);
			// 
			// TxtNombre
			// 
			this.TxtNombre.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNombre.Location = new System.Drawing.Point(166, 115);
			this.TxtNombre.MaxLength = 25;
			this.TxtNombre.Name = "TxtNombre";
			this.TxtNombre.Size = new System.Drawing.Size(219, 29);
			this.TxtNombre.TabIndex = 2;
			this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// txtCedula
			// 
			this.txtCedula.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.Location = new System.Drawing.Point(181, 63);
			this.txtCedula.MaxLength = 8;
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(120, 29);
			this.txtCedula.TabIndex = 1;
			this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedulaKeyPress);
			// 
			// LblNombre
			// 
			this.LblNombre.AutoSize = true;
			this.LblNombre.BackColor = System.Drawing.Color.Transparent;
			this.LblNombre.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNombre.ForeColor = System.Drawing.Color.White;
			this.LblNombre.Location = new System.Drawing.Point(86, 115);
			this.LblNombre.Name = "LblNombre";
			this.LblNombre.Size = new System.Drawing.Size(74, 32);
			this.LblNombre.TabIndex = 34;
			this.LblNombre.Text = "Nombre:";
			// 
			// LblCedula
			// 
			this.LblCedula.AutoSize = true;
			this.LblCedula.BackColor = System.Drawing.Color.Transparent;
			this.LblCedula.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCedula.ForeColor = System.Drawing.Color.White;
			this.LblCedula.Location = new System.Drawing.Point(111, 63);
			this.LblCedula.Name = "LblCedula";
			this.LblCedula.Size = new System.Drawing.Size(67, 32);
			this.LblCedula.TabIndex = 29;
			this.LblCedula.Text = "Cedula:";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
			this.lblDireccion.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDireccion.ForeColor = System.Drawing.Color.White;
			this.lblDireccion.Location = new System.Drawing.Point(16, 220);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(84, 32);
			this.lblDireccion.TabIndex = 40;
			this.lblDireccion.Text = "Direccion:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(96, 220);
			this.txtDireccion.MaxLength = 25;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(391, 29);
			this.txtDireccion.TabIndex = 5;
			this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionKeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(347, 263);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 32);
			this.label1.TabIndex = 43;
			this.label1.Text = "Telefono Residencial:";
			// 
			// txtTelefonoR
			// 
			this.txtTelefonoR.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefonoR.Location = new System.Drawing.Point(357, 303);
			this.txtTelefonoR.MaxLength = 11;
			this.txtTelefonoR.Name = "txtTelefonoR";
			this.txtTelefonoR.Size = new System.Drawing.Size(130, 29);
			this.txtTelefonoR.TabIndex = 8;
			this.txtTelefonoR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoRKeyPress);
			// 
			// BotonReiniciar
			// 
			this.BotonReiniciar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonReiniciar.FlatAppearance.BorderSize = 0;
			this.BotonReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonReiniciar.ForeColor = System.Drawing.Color.White;
			this.BotonReiniciar.Location = new System.Drawing.Point(12, 375);
			this.BotonReiniciar.Name = "BotonReiniciar";
			this.BotonReiniciar.Size = new System.Drawing.Size(70, 23);
			this.BotonReiniciar.TabIndex = 44;
			this.BotonReiniciar.Text = "Reiniciar";
			this.BotonReiniciar.UseVisualStyleBackColor = false;
			this.BotonReiniciar.Click += new System.EventHandler(this.BotonReiniciarClick);
			// 
			// AgregarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(511, 407);
			this.Controls.Add(this.BotonReiniciar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTelefonoR);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.lblDireccion);
			this.Controls.Add(this.LblAgregado);
			this.Controls.Add(this.LblFijo);
			this.Controls.Add(this.BotonBuscar);
			this.Controls.Add(this.BotonCerrar);
			this.Controls.Add(this.BotonAgregar_Actualizar);
			this.Controls.Add(this.LblTelefonoP);
			this.Controls.Add(this.TxtTelefonoP);
			this.Controls.Add(this.LblFechaFabricacion);
			this.Controls.Add(this.LblApellido);
			this.Controls.Add(this.LblCorreo);
			this.Controls.Add(this.TxtNacimiento);
			this.Controls.Add(this.TxtApellido);
			this.Controls.Add(this.TxtCorreo);
			this.Controls.Add(this.TxtNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.LblNombre);
			this.Controls.Add(this.LblCedula);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AgregarCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AgregarCliente";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BotonReiniciar;
		public System.Windows.Forms.TextBox txtTelefonoR;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Label LblCedula;
		private System.Windows.Forms.Label LblNombre;
		public System.Windows.Forms.TextBox txtCedula;
		public System.Windows.Forms.TextBox TxtNombre;
		public System.Windows.Forms.TextBox TxtCorreo;
		public System.Windows.Forms.TextBox TxtApellido;
		public System.Windows.Forms.MaskedTextBox TxtNacimiento;
		private System.Windows.Forms.Label LblCorreo;
		private System.Windows.Forms.Label LblApellido;
		private System.Windows.Forms.Label LblFechaFabricacion;
		public System.Windows.Forms.TextBox TxtTelefonoP;
		private System.Windows.Forms.Label LblTelefonoP;
		private System.Windows.Forms.Button BotonAgregar_Actualizar;
		private System.Windows.Forms.Button BotonCerrar;
		private System.Windows.Forms.Button BotonBuscar;
		public System.Windows.Forms.Label LblFijo;
		public System.Windows.Forms.Label LblAgregado;
	}
}
