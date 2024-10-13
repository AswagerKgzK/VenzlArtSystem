/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 29/4/2023
 * Hora: 7:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class VenderProductos
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenderProductos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.LblTelefonoC = new System.Windows.Forms.Label();
			this.LblApellidoC = new System.Windows.Forms.Label();
			this.LblNombreC = new System.Windows.Forms.Label();
			this.LblCedulaC = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.BotonEliminar = new System.Windows.Forms.Button();
			this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
			this.BotonFacturar = new System.Windows.Forms.Button();
			this.BotonCantidad = new System.Windows.Forms.Button();
			this.BotonCerrar = new System.Windows.Forms.Button();
			this.BotonCliente = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.PanelLogo = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.LblDocumento = new System.Windows.Forms.Label();
			this.LblTiempo = new System.Windows.Forms.Label();
			this.LblTotal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Intervalos = new System.Windows.Forms.Timer(this.components);
			this.PanelDescripcion = new System.Windows.Forms.Panel();
			this.LblExistencia = new System.Windows.Forms.Label();
			this.LblDisponible = new System.Windows.Forms.Label();
			this.LblFechaIngreso = new System.Windows.Forms.Label();
			this.LblFabricado = new System.Windows.Forms.Label();
			this.LblTipo = new System.Windows.Forms.Label();
			this.LblArticulo = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.BotonBuscar = new System.Windows.Forms.Button();
			this.TxtCodigo = new System.Windows.Forms.TextBox();
			this.LblCodigo = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.DatosVenta = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiasPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
			this.PanelLogo.SuspendLayout();
			this.panel3.SuspendLayout();
			this.PanelDescripcion.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DatosVenta)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.LblTelefonoC);
			this.panel1.Controls.Add(this.LblApellidoC);
			this.panel1.Controls.Add(this.LblNombreC);
			this.panel1.Controls.Add(this.LblCedulaC);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.BotonCliente);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 373);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(719, 130);
			this.panel1.TabIndex = 0;
			// 
			// LblTelefonoC
			// 
			this.LblTelefonoC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTelefonoC.ForeColor = System.Drawing.Color.White;
			this.LblTelefonoC.Location = new System.Drawing.Point(180, 90);
			this.LblTelefonoC.Name = "LblTelefonoC";
			this.LblTelefonoC.Size = new System.Drawing.Size(130, 30);
			this.LblTelefonoC.TabIndex = 6;
			this.LblTelefonoC.Text = "Telefono";
			this.LblTelefonoC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblApellidoC
			// 
			this.LblApellidoC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblApellidoC.ForeColor = System.Drawing.Color.White;
			this.LblApellidoC.Location = new System.Drawing.Point(180, 50);
			this.LblApellidoC.Name = "LblApellidoC";
			this.LblApellidoC.Size = new System.Drawing.Size(130, 30);
			this.LblApellidoC.TabIndex = 5;
			this.LblApellidoC.Text = "Apellido";
			this.LblApellidoC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblNombreC
			// 
			this.LblNombreC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNombreC.ForeColor = System.Drawing.Color.White;
			this.LblNombreC.Location = new System.Drawing.Point(180, 10);
			this.LblNombreC.Name = "LblNombreC";
			this.LblNombreC.Size = new System.Drawing.Size(130, 30);
			this.LblNombreC.TabIndex = 4;
			this.LblNombreC.Text = "Nombre";
			this.LblNombreC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblCedulaC
			// 
			this.LblCedulaC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCedulaC.ForeColor = System.Drawing.Color.White;
			this.LblCedulaC.Location = new System.Drawing.Point(20, 10);
			this.LblCedulaC.Name = "LblCedulaC";
			this.LblCedulaC.Size = new System.Drawing.Size(130, 30);
			this.LblCedulaC.TabIndex = 3;
			this.LblCedulaC.Text = "Cedula: ";
			this.LblCedulaC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.BotonEliminar);
			this.panel2.Controls.Add(this.TxtCantidad);
			this.panel2.Controls.Add(this.BotonFacturar);
			this.panel2.Controls.Add(this.BotonCantidad);
			this.panel2.Controls.Add(this.BotonCerrar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.panel2.Location = new System.Drawing.Point(330, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(389, 130);
			this.panel2.TabIndex = 1;
			// 
			// BotonEliminar
			// 
			this.BotonEliminar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonEliminar.FlatAppearance.BorderSize = 0;
			this.BotonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonEliminar.ForeColor = System.Drawing.Color.White;
			this.BotonEliminar.Location = new System.Drawing.Point(10, 80);
			this.BotonEliminar.Name = "BotonEliminar";
			this.BotonEliminar.Size = new System.Drawing.Size(100, 30);
			this.BotonEliminar.TabIndex = 5;
			this.BotonEliminar.Text = "Eliminar";
			this.BotonEliminar.UseVisualStyleBackColor = false;
			this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminarClick);
			// 
			// TxtCantidad
			// 
			this.TxtCantidad.Location = new System.Drawing.Point(40, 13);
			this.TxtCantidad.Maximum = new decimal(new int[] {
									999,
									0,
									0,
									0});
			this.TxtCantidad.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.TxtCantidad.Name = "TxtCantidad";
			this.TxtCantidad.Size = new System.Drawing.Size(80, 26);
			this.TxtCantidad.TabIndex = 4;
			this.TxtCantidad.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// BotonFacturar
			// 
			this.BotonFacturar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonFacturar.FlatAppearance.BorderSize = 0;
			this.BotonFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonFacturar.ForeColor = System.Drawing.Color.White;
			this.BotonFacturar.Location = new System.Drawing.Point(230, 10);
			this.BotonFacturar.Name = "BotonFacturar";
			this.BotonFacturar.Size = new System.Drawing.Size(105, 33);
			this.BotonFacturar.TabIndex = 3;
			this.BotonFacturar.Text = "Facturar";
			this.BotonFacturar.UseVisualStyleBackColor = false;
			this.BotonFacturar.Click += new System.EventHandler(this.BotonFacturarClick);
			// 
			// BotonCantidad
			// 
			this.BotonCantidad.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCantidad.FlatAppearance.BorderSize = 0;
			this.BotonCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCantidad.ForeColor = System.Drawing.Color.White;
			this.BotonCantidad.Location = new System.Drawing.Point(120, 10);
			this.BotonCantidad.Name = "BotonCantidad";
			this.BotonCantidad.Size = new System.Drawing.Size(105, 33);
			this.BotonCantidad.TabIndex = 1;
			this.BotonCantidad.Text = "Cantidad";
			this.BotonCantidad.UseVisualStyleBackColor = false;
			this.BotonCantidad.Click += new System.EventHandler(this.BotonCantidadClick);
			// 
			// BotonCerrar
			// 
			this.BotonCerrar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCerrar.FlatAppearance.BorderSize = 0;
			this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCerrar.ForeColor = System.Drawing.Color.White;
			this.BotonCerrar.Location = new System.Drawing.Point(260, 80);
			this.BotonCerrar.Name = "BotonCerrar";
			this.BotonCerrar.Size = new System.Drawing.Size(105, 33);
			this.BotonCerrar.TabIndex = 10;
			this.BotonCerrar.Text = "Cerrar";
			this.BotonCerrar.UseVisualStyleBackColor = false;
			this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrarClick);
			// 
			// BotonCliente
			// 
			this.BotonCliente.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCliente.FlatAppearance.BorderSize = 0;
			this.BotonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonCliente.ForeColor = System.Drawing.Color.White;
			this.BotonCliente.Location = new System.Drawing.Point(20, 80);
			this.BotonCliente.Name = "BotonCliente";
			this.BotonCliente.Size = new System.Drawing.Size(105, 33);
			this.BotonCliente.TabIndex = 2;
			this.BotonCliente.Text = "Cliente";
			this.BotonCliente.UseVisualStyleBackColor = false;
			this.BotonCliente.Click += new System.EventHandler(this.BotonClienteClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Stencil", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(114, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "System";
			// 
			// PanelLogo
			// 
			this.PanelLogo.BackColor = System.Drawing.Color.Transparent;
			this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PanelLogo.Controls.Add(this.panel3);
			this.PanelLogo.Controls.Add(this.label2);
			this.PanelLogo.Controls.Add(this.label1);
			this.PanelLogo.Controls.Add(this.label3);
			this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelLogo.Location = new System.Drawing.Point(0, 0);
			this.PanelLogo.Name = "PanelLogo";
			this.PanelLogo.Size = new System.Drawing.Size(719, 80);
			this.PanelLogo.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.LblDocumento);
			this.panel3.Controls.Add(this.LblTiempo);
			this.panel3.Controls.Add(this.LblTotal);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(260, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(459, 80);
			this.panel3.TabIndex = 6;
			// 
			// LblDocumento
			// 
			this.LblDocumento.AutoSize = true;
			this.LblDocumento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblDocumento.ForeColor = System.Drawing.Color.White;
			this.LblDocumento.Location = new System.Drawing.Point(80, 60);
			this.LblDocumento.Name = "LblDocumento";
			this.LblDocumento.Size = new System.Drawing.Size(92, 19);
			this.LblDocumento.TabIndex = 7;
			this.LblDocumento.Text = "Documento: ";
			// 
			// LblTiempo
			// 
			this.LblTiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTiempo.ForeColor = System.Drawing.Color.White;
			this.LblTiempo.Location = new System.Drawing.Point(0, 30);
			this.LblTiempo.Name = "LblTiempo";
			this.LblTiempo.Size = new System.Drawing.Size(310, 20);
			this.LblTiempo.TabIndex = 0;
			this.LblTiempo.Text = "Tiempo";
			this.LblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblTotal
			// 
			this.LblTotal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTotal.ForeColor = System.Drawing.Color.White;
			this.LblTotal.Location = new System.Drawing.Point(300, 10);
			this.LblTotal.Name = "LblTotal";
			this.LblTotal.Size = new System.Drawing.Size(150, 60);
			this.LblTotal.TabIndex = 1;
			this.LblTotal.Text = "0,00";
			this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(60, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "enzlArt";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Stencil", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(27, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 50);
			this.label3.TabIndex = 7;
			this.label3.Text = "V";
			// 
			// Intervalos
			// 
			this.Intervalos.Enabled = true;
			this.Intervalos.Interval = 1000;
			this.Intervalos.Tick += new System.EventHandler(this.IntervalosTick);
			// 
			// PanelDescripcion
			// 
			this.PanelDescripcion.Controls.Add(this.LblExistencia);
			this.PanelDescripcion.Controls.Add(this.LblDisponible);
			this.PanelDescripcion.Controls.Add(this.LblFechaIngreso);
			this.PanelDescripcion.Controls.Add(this.LblFabricado);
			this.PanelDescripcion.Controls.Add(this.LblTipo);
			this.PanelDescripcion.Controls.Add(this.LblArticulo);
			this.PanelDescripcion.Dock = System.Windows.Forms.DockStyle.Right;
			this.PanelDescripcion.ForeColor = System.Drawing.Color.White;
			this.PanelDescripcion.Location = new System.Drawing.Point(15, 0);
			this.PanelDescripcion.Name = "PanelDescripcion";
			this.PanelDescripcion.Padding = new System.Windows.Forms.Padding(5);
			this.PanelDescripcion.Size = new System.Drawing.Size(165, 293);
			this.PanelDescripcion.TabIndex = 1;
			// 
			// LblExistencia
			// 
			this.LblExistencia.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LblExistencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblExistencia.Location = new System.Drawing.Point(5, 228);
			this.LblExistencia.Name = "LblExistencia";
			this.LblExistencia.Size = new System.Drawing.Size(155, 30);
			this.LblExistencia.TabIndex = 5;
			this.LblExistencia.Text = "Existencia:  ";
			this.LblExistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblDisponible
			// 
			this.LblDisponible.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LblDisponible.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblDisponible.Location = new System.Drawing.Point(5, 258);
			this.LblDisponible.Name = "LblDisponible";
			this.LblDisponible.Size = new System.Drawing.Size(155, 30);
			this.LblDisponible.TabIndex = 10;
			this.LblDisponible.Text = "Disponible";
			this.LblDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblFechaIngreso
			// 
			this.LblFechaIngreso.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblFechaIngreso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblFechaIngreso.Location = new System.Drawing.Point(5, 140);
			this.LblFechaIngreso.Name = "LblFechaIngreso";
			this.LblFechaIngreso.Size = new System.Drawing.Size(155, 60);
			this.LblFechaIngreso.TabIndex = 3;
			this.LblFechaIngreso.Text = "Fecha de Ingreso:  ";
			this.LblFechaIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblFabricado
			// 
			this.LblFabricado.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblFabricado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblFabricado.Location = new System.Drawing.Point(5, 90);
			this.LblFabricado.Name = "LblFabricado";
			this.LblFabricado.Size = new System.Drawing.Size(155, 50);
			this.LblFabricado.TabIndex = 2;
			this.LblFabricado.Text = "Fabricado:  ";
			this.LblFabricado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblTipo
			// 
			this.LblTipo.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblTipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblTipo.Location = new System.Drawing.Point(5, 40);
			this.LblTipo.Margin = new System.Windows.Forms.Padding(5);
			this.LblTipo.Name = "LblTipo";
			this.LblTipo.Size = new System.Drawing.Size(155, 50);
			this.LblTipo.TabIndex = 1;
			this.LblTipo.Text = "Tipo: ";
			this.LblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblArticulo
			// 
			this.LblArticulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblArticulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblArticulo.Location = new System.Drawing.Point(5, 5);
			this.LblArticulo.Margin = new System.Windows.Forms.Padding(5);
			this.LblArticulo.Name = "LblArticulo";
			this.LblArticulo.Size = new System.Drawing.Size(155, 35);
			this.LblArticulo.TabIndex = 0;
			this.LblArticulo.Text = "Articulo";
			this.LblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Transparent;
			this.panel6.Controls.Add(this.PanelDescripcion);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 80);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(180, 293);
			this.panel6.TabIndex = 7;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Transparent;
			this.panel7.Controls.Add(this.BotonBuscar);
			this.panel7.Controls.Add(this.TxtCodigo);
			this.panel7.Controls.Add(this.LblCodigo);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(180, 80);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(539, 30);
			this.panel7.TabIndex = 8;
			// 
			// BotonBuscar
			// 
			this.BotonBuscar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonBuscar.Dock = System.Windows.Forms.DockStyle.Right;
			this.BotonBuscar.FlatAppearance.BorderSize = 0;
			this.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonBuscar.ForeColor = System.Drawing.Color.White;
			this.BotonBuscar.Location = new System.Drawing.Point(469, 0);
			this.BotonBuscar.Name = "BotonBuscar";
			this.BotonBuscar.Size = new System.Drawing.Size(70, 30);
			this.BotonBuscar.TabIndex = 2;
			this.BotonBuscar.Text = "Buscar";
			this.BotonBuscar.UseVisualStyleBackColor = false;
			this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscarClick);
			// 
			// TxtCodigo
			// 
			this.TxtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtCodigo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic);
			this.TxtCodigo.Location = new System.Drawing.Point(90, 0);
			this.TxtCodigo.Name = "TxtCodigo";
			this.TxtCodigo.Size = new System.Drawing.Size(449, 29);
			this.TxtCodigo.TabIndex = 0;
			this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoKeyPress);
			this.TxtCodigo.Leave += new System.EventHandler(this.TxtCodigoLeave);
			// 
			// LblCodigo
			// 
			this.LblCodigo.Dock = System.Windows.Forms.DockStyle.Left;
			this.LblCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LblCodigo.ForeColor = System.Drawing.Color.White;
			this.LblCodigo.Location = new System.Drawing.Point(0, 0);
			this.LblCodigo.Margin = new System.Windows.Forms.Padding(5);
			this.LblCodigo.Name = "LblCodigo";
			this.LblCodigo.Size = new System.Drawing.Size(90, 30);
			this.LblCodigo.TabIndex = 1;
			this.LblCodigo.Text = "Codigo: ";
			this.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Transparent;
			this.panel4.Controls.Add(this.DatosVenta);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(180, 110);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(25);
			this.panel4.Size = new System.Drawing.Size(539, 263);
			this.panel4.TabIndex = 9;
			// 
			// DatosVenta
			// 
			this.DatosVenta.AllowUserToAddRows = false;
			this.DatosVenta.AllowUserToDeleteRows = false;
			this.DatosVenta.AllowUserToResizeColumns = false;
			this.DatosVenta.AllowUserToResizeRows = false;
			this.DatosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DatosVenta.BackgroundColor = System.Drawing.Color.MediumPurple;
			this.DatosVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DatosVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DatosVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.DatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DatosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Codigo,
									this.Articulo,
									this.Titulo,
									this.Precio,
									this.DiasPrestamo,
									this.Cantidad,
									this.Total});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DatosVenta.DefaultCellStyle = dataGridViewCellStyle2;
			this.DatosVenta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DatosVenta.EnableHeadersVisualStyles = false;
			this.DatosVenta.GridColor = System.Drawing.Color.Black;
			this.DatosVenta.Location = new System.Drawing.Point(25, 25);
			this.DatosVenta.Name = "DatosVenta";
			this.DatosVenta.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DatosVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DatosVenta.Size = new System.Drawing.Size(489, 213);
			this.DatosVenta.TabIndex = 1;
			this.DatosVenta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatosVentaCellMouseClick);
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// Articulo
			// 
			this.Articulo.HeaderText = "Titulo";
			this.Articulo.Name = "Articulo";
			this.Articulo.ReadOnly = true;
			// 
			// Titulo
			// 
			this.Titulo.HeaderText = "Descripcion";
			this.Titulo.Name = "Titulo";
			this.Titulo.ReadOnly = true;
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			// 
			// DiasPrestamo
			// 
			this.DiasPrestamo.HeaderText = "Dias de Prestamo";
			this.DiasPrestamo.Name = "DiasPrestamo";
			this.DiasPrestamo.ReadOnly = true;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// VenderProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(719, 503);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.PanelLogo);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "VenderProductos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VenderProductos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
			this.PanelLogo.ResumeLayout(false);
			this.PanelLogo.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.PanelDescripcion.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DatosVenta)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LblDocumento;
		private System.Windows.Forms.Label LblTelefonoC;
		private System.Windows.Forms.Label LblCedulaC;
		private System.Windows.Forms.Label LblNombreC;
		private System.Windows.Forms.Label LblApellidoC;
		private System.Windows.Forms.Button BotonEliminar;
		private System.Windows.Forms.NumericUpDown TxtCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiasPrestamo;
		private System.Windows.Forms.Label LblCodigo;
		private System.Windows.Forms.TextBox TxtCodigo;
		private System.Windows.Forms.Button BotonBuscar;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label LblTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridView DatosVenta;
		private System.Windows.Forms.Label LblArticulo;
		private System.Windows.Forms.Label LblFabricado;
		private System.Windows.Forms.Label LblFechaIngreso;
		private System.Windows.Forms.Label LblDisponible;
		private System.Windows.Forms.Label LblExistencia;
		private System.Windows.Forms.Panel PanelDescripcion;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Timer Intervalos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblTiempo;
		private System.Windows.Forms.Label LblTotal;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel PanelLogo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BotonCerrar;
		private System.Windows.Forms.Button BotonCantidad;
		private System.Windows.Forms.Button BotonCliente;
		private System.Windows.Forms.Button BotonFacturar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}
