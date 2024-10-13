/*
 * Creado por SharpDevelop.
 * Usuario: tupun
 * Fecha: 22/5/2023
 * Hora: 4:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class RealizarDevolucion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarDevolucion));
			this.TxtCodigo = new System.Windows.Forms.TextBox();
			this.LblDocumento = new System.Windows.Forms.Label();
			this.LblCodigo = new System.Windows.Forms.Label();
			this.LblArticulo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.LblNombreArticulo = new System.Windows.Forms.Label();
			this.BotonBuscar = new System.Windows.Forms.Button();
			this.BotonRegistrar = new System.Windows.Forms.Button();
			this.TxtCantidad = new System.Windows.Forms.TextBox();
			this.BotonClose = new System.Windows.Forms.Button();
			this.ComboTipo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TxtCodigo
			// 
			this.TxtCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.TxtCodigo.Location = new System.Drawing.Point(118, 37);
			this.TxtCodigo.Name = "TxtCodigo";
			this.TxtCodigo.Size = new System.Drawing.Size(240, 26);
			this.TxtCodigo.TabIndex = 0;
			this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoKeyPress);
			// 
			// LblDocumento
			// 
			this.LblDocumento.BackColor = System.Drawing.Color.Transparent;
			this.LblDocumento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblDocumento.ForeColor = System.Drawing.Color.White;
			this.LblDocumento.Location = new System.Drawing.Point(281, 9);
			this.LblDocumento.Name = "LblDocumento";
			this.LblDocumento.Size = new System.Drawing.Size(207, 23);
			this.LblDocumento.TabIndex = 1;
			this.LblDocumento.Text = "Documento Nro: ";
			this.LblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblCodigo
			// 
			this.LblCodigo.AutoSize = true;
			this.LblCodigo.BackColor = System.Drawing.Color.Transparent;
			this.LblCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblCodigo.ForeColor = System.Drawing.Color.White;
			this.LblCodigo.Location = new System.Drawing.Point(56, 40);
			this.LblCodigo.Name = "LblCodigo";
			this.LblCodigo.Size = new System.Drawing.Size(61, 19);
			this.LblCodigo.TabIndex = 2;
			this.LblCodigo.Text = "Codigo:";
			this.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblArticulo
			// 
			this.LblArticulo.BackColor = System.Drawing.Color.Transparent;
			this.LblArticulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblArticulo.ForeColor = System.Drawing.Color.White;
			this.LblArticulo.Location = new System.Drawing.Point(56, 137);
			this.LblArticulo.Name = "LblArticulo";
			this.LblArticulo.Size = new System.Drawing.Size(100, 23);
			this.LblArticulo.TabIndex = 3;
			this.LblArticulo.Text = "Articulo:";
			this.LblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(120, 278);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Cantidad:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblNombreArticulo
			// 
			this.LblNombreArticulo.BackColor = System.Drawing.Color.Transparent;
			this.LblNombreArticulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblNombreArticulo.ForeColor = System.Drawing.Color.White;
			this.LblNombreArticulo.Location = new System.Drawing.Point(140, 79);
			this.LblNombreArticulo.Name = "LblNombreArticulo";
			this.LblNombreArticulo.Size = new System.Drawing.Size(292, 139);
			this.LblNombreArticulo.TabIndex = 5;
			this.LblNombreArticulo.Text = "All dates of object.";
			this.LblNombreArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BotonBuscar
			// 
			this.BotonBuscar.AutoSize = true;
			this.BotonBuscar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonBuscar.FlatAppearance.BorderSize = 0;
			this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonBuscar.ForeColor = System.Drawing.Color.White;
			this.BotonBuscar.Location = new System.Drawing.Point(357, 35);
			this.BotonBuscar.Name = "BotonBuscar";
			this.BotonBuscar.Size = new System.Drawing.Size(75, 31);
			this.BotonBuscar.TabIndex = 6;
			this.BotonBuscar.Text = "Buscar";
			this.BotonBuscar.UseVisualStyleBackColor = false;
			this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscarClick);
			// 
			// BotonRegistrar
			// 
			this.BotonRegistrar.AutoSize = true;
			this.BotonRegistrar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonRegistrar.FlatAppearance.BorderSize = 0;
			this.BotonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonRegistrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonRegistrar.ForeColor = System.Drawing.Color.White;
			this.BotonRegistrar.Location = new System.Drawing.Point(215, 309);
			this.BotonRegistrar.Name = "BotonRegistrar";
			this.BotonRegistrar.Size = new System.Drawing.Size(82, 31);
			this.BotonRegistrar.TabIndex = 7;
			this.BotonRegistrar.Text = "Registrar";
			this.BotonRegistrar.UseVisualStyleBackColor = false;
			this.BotonRegistrar.Click += new System.EventHandler(this.BotonRegistrarClick);
			// 
			// TxtCantidad
			// 
			this.TxtCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.TxtCantidad.Location = new System.Drawing.Point(236, 277);
			this.TxtCantidad.Name = "TxtCantidad";
			this.TxtCantidad.Size = new System.Drawing.Size(121, 26);
			this.TxtCantidad.TabIndex = 8;
			// 
			// BotonClose
			// 
			this.BotonClose.AutoSize = true;
			this.BotonClose.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonClose.FlatAppearance.BorderSize = 0;
			this.BotonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonClose.ForeColor = System.Drawing.Color.White;
			this.BotonClose.Location = new System.Drawing.Point(413, 309);
			this.BotonClose.Name = "BotonClose";
			this.BotonClose.Size = new System.Drawing.Size(75, 31);
			this.BotonClose.TabIndex = 9;
			this.BotonClose.Text = "Cerrar";
			this.BotonClose.UseVisualStyleBackColor = false;
			this.BotonClose.Click += new System.EventHandler(this.BotonCloseClick);
			// 
			// ComboTipo
			// 
			this.ComboTipo.BackColor = System.Drawing.Color.White;
			this.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboTipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.ComboTipo.FormattingEnabled = true;
			this.ComboTipo.Items.AddRange(new object[] {
									"Compra",
									"Devolucion"});
			this.ComboTipo.Location = new System.Drawing.Point(250, 238);
			this.ComboTipo.Name = "ComboTipo";
			this.ComboTipo.Size = new System.Drawing.Size(121, 27);
			this.ComboTipo.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(120, 239);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Modo de entrada:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RealizarDevolucion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkViolet;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(500, 350);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ComboTipo);
			this.Controls.Add(this.BotonClose);
			this.Controls.Add(this.TxtCantidad);
			this.Controls.Add(this.BotonRegistrar);
			this.Controls.Add(this.BotonBuscar);
			this.Controls.Add(this.LblNombreArticulo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LblArticulo);
			this.Controls.Add(this.LblCodigo);
			this.Controls.Add(this.LblDocumento);
			this.Controls.Add(this.TxtCodigo);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RealizarDevolucion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RealizarDevolucion";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ComboTipo;
		private System.Windows.Forms.Button BotonClose;
		private System.Windows.Forms.TextBox TxtCantidad;
		private System.Windows.Forms.Button BotonRegistrar;
		private System.Windows.Forms.Button BotonBuscar;
		private System.Windows.Forms.Label LblNombreArticulo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LblArticulo;
		private System.Windows.Forms.Label LblCodigo;
		private System.Windows.Forms.Label LblDocumento;
		private System.Windows.Forms.TextBox TxtCodigo;
	}
}
