/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 29/4/2023
 * Hora: 8:50 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class AgregarArticulo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarArticulo));
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.TxtArticulo = new System.Windows.Forms.TextBox();
			this.TxtTipo = new System.Windows.Forms.TextBox();
			this.TxtTitulo = new System.Windows.Forms.TextBox();
			this.ChBoxDisponible = new System.Windows.Forms.CheckBox();
			this.TxtFechaF = new System.Windows.Forms.MaskedTextBox();
			this.LblCodigo = new System.Windows.Forms.Label();
			this.LblTipo = new System.Windows.Forms.Label();
			this.LblTitulo = new System.Windows.Forms.Label();
			this.LblNombre = new System.Windows.Forms.Label();
			this.LblFechaFabricacion = new System.Windows.Forms.Label();
			this.TxtPrecio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BotonAgregar_Actualizar = new System.Windows.Forms.Button();
			this.BotonCerrar = new System.Windows.Forms.Button();
			this.BotonBuscar = new System.Windows.Forms.Button();
			this.LblFijo = new System.Windows.Forms.Label();
			this.LblAgregado = new System.Windows.Forms.Label();
			this.BotonReiniciar = new System.Windows.Forms.Button();
			this.LblPrestamo = new System.Windows.Forms.Label();
			this.TxtDias = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
			this.txtCodigo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(182, 34);
			this.txtCodigo.MaxLength = 14;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(120, 29);
			this.txtCodigo.TabIndex = 0;
			this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoKeyPress);
			this.txtCodigo.Leave += new System.EventHandler(this.TxtCodigoLeave);
			// 
			// TxtArticulo
			// 
			this.TxtArticulo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtArticulo.Location = new System.Drawing.Point(149, 70);
			this.TxtArticulo.MaxLength = 25;
			this.TxtArticulo.Name = "TxtArticulo";
			this.TxtArticulo.Size = new System.Drawing.Size(269, 29);
			this.TxtArticulo.TabIndex = 1;
			this.TxtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtArticuloKeyPress);
			// 
			// TxtTipo
			// 
			this.TxtTipo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTipo.Location = new System.Drawing.Point(192, 140);
			this.TxtTipo.MaxLength = 25;
			this.TxtTipo.Name = "TxtTipo";
			this.TxtTipo.Size = new System.Drawing.Size(190, 29);
			this.TxtTipo.TabIndex = 3;
			this.TxtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoKeyPress);
			// 
			// TxtTitulo
			// 
			this.TxtTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTitulo.Location = new System.Drawing.Point(112, 105);
			this.TxtTitulo.MaxLength = 35;
			this.TxtTitulo.Name = "TxtTitulo";
			this.TxtTitulo.Size = new System.Drawing.Size(357, 29);
			this.TxtTitulo.TabIndex = 2;
			this.TxtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTituloKeyPress);
			// 
			// ChBoxDisponible
			// 
			this.ChBoxDisponible.BackColor = System.Drawing.Color.Transparent;
			this.ChBoxDisponible.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChBoxDisponible.ForeColor = System.Drawing.Color.White;
			this.ChBoxDisponible.Location = new System.Drawing.Point(192, 276);
			this.ChBoxDisponible.Name = "ChBoxDisponible";
			this.ChBoxDisponible.Size = new System.Drawing.Size(140, 30);
			this.ChBoxDisponible.TabIndex = 8;
			this.ChBoxDisponible.Text = "Disponibilidad";
			this.ChBoxDisponible.UseVisualStyleBackColor = false;
			// 
			// TxtFechaF
			// 
			this.TxtFechaF.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtFechaF.Location = new System.Drawing.Point(55, 231);
			this.TxtFechaF.Mask = "00/00/0000";
			this.TxtFechaF.Name = "TxtFechaF";
			this.TxtFechaF.Size = new System.Drawing.Size(100, 29);
			this.TxtFechaF.TabIndex = 4;
			this.TxtFechaF.ValidatingType = typeof(System.DateTime);
			this.TxtFechaF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaFKeyPress);
			// 
			// LblCodigo
			// 
			this.LblCodigo.AutoSize = true;
			this.LblCodigo.BackColor = System.Drawing.Color.Transparent;
			this.LblCodigo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCodigo.ForeColor = System.Drawing.Color.White;
			this.LblCodigo.Location = new System.Drawing.Point(112, 34);
			this.LblCodigo.Name = "LblCodigo";
			this.LblCodigo.Size = new System.Drawing.Size(68, 32);
			this.LblCodigo.TabIndex = 8;
			this.LblCodigo.Text = "Codigo:";
			// 
			// LblTipo
			// 
			this.LblTipo.AutoSize = true;
			this.LblTipo.BackColor = System.Drawing.Color.Transparent;
			this.LblTipo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTipo.ForeColor = System.Drawing.Color.White;
			this.LblTipo.Location = new System.Drawing.Point(132, 140);
			this.LblTipo.Name = "LblTipo";
			this.LblTipo.Size = new System.Drawing.Size(50, 32);
			this.LblTipo.TabIndex = 9;
			this.LblTipo.Text = "Tipo:";
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.LblTitulo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitulo.ForeColor = System.Drawing.Color.White;
			this.LblTitulo.Location = new System.Drawing.Point(19, 105);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(99, 32);
			this.LblTitulo.TabIndex = 10;
			this.LblTitulo.Text = "Descripcion:";
			// 
			// LblNombre
			// 
			this.LblNombre.AutoSize = true;
			this.LblNombre.BackColor = System.Drawing.Color.Transparent;
			this.LblNombre.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNombre.ForeColor = System.Drawing.Color.White;
			this.LblNombre.Location = new System.Drawing.Point(79, 70);
			this.LblNombre.Name = "LblNombre";
			this.LblNombre.Size = new System.Drawing.Size(63, 32);
			this.LblNombre.TabIndex = 11;
			this.LblNombre.Text = "Titulo: ";
			// 
			// LblFechaFabricacion
			// 
			this.LblFechaFabricacion.AutoSize = true;
			this.LblFechaFabricacion.BackColor = System.Drawing.Color.Transparent;
			this.LblFechaFabricacion.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFechaFabricacion.ForeColor = System.Drawing.Color.White;
			this.LblFechaFabricacion.Location = new System.Drawing.Point(35, 191);
			this.LblFechaFabricacion.Name = "LblFechaFabricacion";
			this.LblFechaFabricacion.Size = new System.Drawing.Size(158, 32);
			this.LblFechaFabricacion.TabIndex = 12;
			this.LblFechaFabricacion.Text = "Fecha de Fabricacion:";
			// 
			// TxtPrecio
			// 
			this.TxtPrecio.BackColor = System.Drawing.SystemColors.Window;
			this.TxtPrecio.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtPrecio.Location = new System.Drawing.Point(220, 231);
			this.TxtPrecio.MaxLength = 8;
			this.TxtPrecio.Name = "TxtPrecio";
			this.TxtPrecio.Size = new System.Drawing.Size(70, 29);
			this.TxtPrecio.TabIndex = 5;
			this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioKeyPress);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(220, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 32);
			this.label1.TabIndex = 14;
			this.label1.Text = "Precio:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// BotonAgregar_Actualizar
			// 
			this.BotonAgregar_Actualizar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonAgregar_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonAgregar_Actualizar.FlatAppearance.BorderSize = 0;
			this.BotonAgregar_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonAgregar_Actualizar.ForeColor = System.Drawing.Color.White;
			this.BotonAgregar_Actualizar.Location = new System.Drawing.Point(418, 276);
			this.BotonAgregar_Actualizar.Name = "BotonAgregar_Actualizar";
			this.BotonAgregar_Actualizar.Size = new System.Drawing.Size(70, 40);
			this.BotonAgregar_Actualizar.TabIndex = 8;
			this.BotonAgregar_Actualizar.Text = "Agregar o Actualizar";
			this.BotonAgregar_Actualizar.UseVisualStyleBackColor = false;
			this.BotonAgregar_Actualizar.Click += new System.EventHandler(this.BotonAgregar_ActualizarClick);
			// 
			// BotonCerrar
			// 
			this.BotonCerrar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCerrar.FlatAppearance.BorderSize = 0;
			this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCerrar.ForeColor = System.Drawing.Color.White;
			this.BotonCerrar.Location = new System.Drawing.Point(427, 4);
			this.BotonCerrar.Name = "BotonCerrar";
			this.BotonCerrar.Size = new System.Drawing.Size(70, 30);
			this.BotonCerrar.TabIndex = 9;
			this.BotonCerrar.Text = "Cerrar";
			this.BotonCerrar.UseVisualStyleBackColor = false;
			this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrarClick);
			// 
			// BotonBuscar
			// 
			this.BotonBuscar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonBuscar.FlatAppearance.BorderSize = 0;
			this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonBuscar.ForeColor = System.Drawing.Color.White;
			this.BotonBuscar.Location = new System.Drawing.Point(312, 34);
			this.BotonBuscar.Name = "BotonBuscar";
			this.BotonBuscar.Size = new System.Drawing.Size(70, 30);
			this.BotonBuscar.TabIndex = 10;
			this.BotonBuscar.Text = "Buscar";
			this.BotonBuscar.UseVisualStyleBackColor = false;
			this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscarClick);
			// 
			// LblFijo
			// 
			this.LblFijo.AutoSize = true;
			this.LblFijo.BackColor = System.Drawing.Color.Transparent;
			this.LblFijo.ForeColor = System.Drawing.Color.White;
			this.LblFijo.Location = new System.Drawing.Point(2, 4);
			this.LblFijo.Name = "LblFijo";
			this.LblFijo.Size = new System.Drawing.Size(127, 13);
			this.LblFijo.TabIndex = 19;
			this.LblFijo.Text = "Agregado al inventario el:";
			this.LblFijo.Visible = false;
			// 
			// LblAgregado
			// 
			this.LblAgregado.AutoSize = true;
			this.LblAgregado.BackColor = System.Drawing.Color.Transparent;
			this.LblAgregado.ForeColor = System.Drawing.Color.White;
			this.LblAgregado.Location = new System.Drawing.Point(135, 4);
			this.LblAgregado.Name = "LblAgregado";
			this.LblAgregado.Size = new System.Drawing.Size(37, 13);
			this.LblAgregado.TabIndex = 20;
			this.LblAgregado.Text = "Fecha";
			this.LblAgregado.Visible = false;
			// 
			// BotonReiniciar
			// 
			this.BotonReiniciar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonReiniciar.FlatAppearance.BorderSize = 0;
			this.BotonReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonReiniciar.ForeColor = System.Drawing.Color.White;
			this.BotonReiniciar.Location = new System.Drawing.Point(12, 293);
			this.BotonReiniciar.Name = "BotonReiniciar";
			this.BotonReiniciar.Size = new System.Drawing.Size(70, 23);
			this.BotonReiniciar.TabIndex = 45;
			this.BotonReiniciar.Text = "Reiniciar";
			this.BotonReiniciar.UseVisualStyleBackColor = false;
			this.BotonReiniciar.Click += new System.EventHandler(this.BotonReiniciarClick);
			// 
			// LblPrestamo
			// 
			this.LblPrestamo.AutoSize = true;
			this.LblPrestamo.BackColor = System.Drawing.Color.Transparent;
			this.LblPrestamo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPrestamo.ForeColor = System.Drawing.Color.White;
			this.LblPrestamo.Location = new System.Drawing.Point(339, 191);
			this.LblPrestamo.Name = "LblPrestamo";
			this.LblPrestamo.Size = new System.Drawing.Size(134, 32);
			this.LblPrestamo.TabIndex = 47;
			this.LblPrestamo.Text = "Dias de Prestamo:";
			// 
			// TxtDias
			// 
			this.TxtDias.BackColor = System.Drawing.SystemColors.Window;
			this.TxtDias.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtDias.Location = new System.Drawing.Point(369, 231);
			this.TxtDias.MaxLength = 8;
			this.TxtDias.Name = "TxtDias";
			this.TxtDias.Size = new System.Drawing.Size(80, 29);
			this.TxtDias.TabIndex = 6;
			this.TxtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDiasKeyPress);
			// 
			// AgregarArticulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(500, 328);
			this.Controls.Add(this.LblPrestamo);
			this.Controls.Add(this.TxtDias);
			this.Controls.Add(this.BotonReiniciar);
			this.Controls.Add(this.LblAgregado);
			this.Controls.Add(this.LblFijo);
			this.Controls.Add(this.BotonBuscar);
			this.Controls.Add(this.BotonCerrar);
			this.Controls.Add(this.BotonAgregar_Actualizar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtPrecio);
			this.Controls.Add(this.LblFechaFabricacion);
			this.Controls.Add(this.LblTitulo);
			this.Controls.Add(this.LblTipo);
			this.Controls.Add(this.TxtFechaF);
			this.Controls.Add(this.ChBoxDisponible);
			this.Controls.Add(this.TxtTitulo);
			this.Controls.Add(this.TxtTipo);
			this.Controls.Add(this.TxtArticulo);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.LblNombre);
			this.Controls.Add(this.LblCodigo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AgregarArticulo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AgregarArticulo";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.TextBox TxtDias;
		private System.Windows.Forms.Label LblPrestamo;
		private System.Windows.Forms.Button BotonReiniciar;
		public System.Windows.Forms.Label LblAgregado;
		public System.Windows.Forms.Label LblFijo;
		private System.Windows.Forms.Button BotonBuscar;
		private System.Windows.Forms.Button BotonCerrar;
		private System.Windows.Forms.Button BotonAgregar_Actualizar;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox TxtPrecio;
		private System.Windows.Forms.Label LblFechaFabricacion;
		private System.Windows.Forms.Label LblNombre;
		private System.Windows.Forms.Label LblTitulo;
		private System.Windows.Forms.Label LblTipo;
		private System.Windows.Forms.Label LblCodigo;
		public System.Windows.Forms.MaskedTextBox TxtFechaF;
		public System.Windows.Forms.CheckBox ChBoxDisponible;
		public System.Windows.Forms.TextBox TxtTitulo;
		public System.Windows.Forms.TextBox TxtTipo;
		public System.Windows.Forms.TextBox TxtArticulo;
		public System.Windows.Forms.TextBox txtCodigo;
	}
}
