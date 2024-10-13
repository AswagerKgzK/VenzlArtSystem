/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 29/4/2023
 * Hora: 7:53 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class Inventario
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
			this.TxtBuscarArticulo = new System.Windows.Forms.TextBox();
			this.TxtBuscarTipo = new System.Windows.Forms.TextBox();
			this.TxtBuscarCodigo = new System.Windows.Forms.TextBox();
			this.DataArticulos = new System.Windows.Forms.DataGridView();
			this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CFechaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiasPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BotonCerrar = new System.Windows.Forms.Button();
			this.LblCodigo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ChBDisponibilidad = new System.Windows.Forms.CheckBox();
			this.Modo_Inventario = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DataArticulos)).BeginInit();
			this.SuspendLayout();
			// 
			// TxtBuscarArticulo
			// 
			this.TxtBuscarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBuscarArticulo.Location = new System.Drawing.Point(130, 20);
			this.TxtBuscarArticulo.Name = "TxtBuscarArticulo";
			this.TxtBuscarArticulo.Size = new System.Drawing.Size(530, 30);
			this.TxtBuscarArticulo.TabIndex = 1;
			this.TxtBuscarArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarArticuloKeyPress);
			// 
			// TxtBuscarTipo
			// 
			this.TxtBuscarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBuscarTipo.Location = new System.Drawing.Point(130, 100);
			this.TxtBuscarTipo.Name = "TxtBuscarTipo";
			this.TxtBuscarTipo.Size = new System.Drawing.Size(530, 30);
			this.TxtBuscarTipo.TabIndex = 1;
			this.TxtBuscarTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarTipoKeyPress);
			// 
			// TxtBuscarCodigo
			// 
			this.TxtBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBuscarCodigo.Location = new System.Drawing.Point(130, 60);
			this.TxtBuscarCodigo.Name = "TxtBuscarCodigo";
			this.TxtBuscarCodigo.Size = new System.Drawing.Size(530, 30);
			this.TxtBuscarCodigo.TabIndex = 1;
			this.TxtBuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarCodigoKeyPress);
			// 
			// DataArticulos
			// 
			this.DataArticulos.AllowUserToAddRows = false;
			this.DataArticulos.AllowUserToDeleteRows = false;
			this.DataArticulos.AllowUserToResizeColumns = false;
			this.DataArticulos.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.DataArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DataArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataArticulos.BackgroundColor = System.Drawing.Color.MediumPurple;
			this.DataArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DataArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DataArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.CCodigo,
									this.CNombre,
									this.CTitulo,
									this.CTipo,
									this.CFechaF,
									this.CPrecio,
									this.CCantidad,
									this.DiasPrestamo});
			this.DataArticulos.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("High Tower Text", 9.75F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataArticulos.DefaultCellStyle = dataGridViewCellStyle3;
			this.DataArticulos.EnableHeadersVisualStyles = false;
			this.DataArticulos.GridColor = System.Drawing.Color.Black;
			this.DataArticulos.Location = new System.Drawing.Point(20, 150);
			this.DataArticulos.MultiSelect = false;
			this.DataArticulos.Name = "DataArticulos";
			this.DataArticulos.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DataArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataArticulos.ShowEditingIcon = false;
			this.DataArticulos.Size = new System.Drawing.Size(660, 290);
			this.DataArticulos.TabIndex = 2;
			this.DataArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataArticulosCellDoubleClick);
			// 
			// CCodigo
			// 
			this.CCodigo.HeaderText = "Codigo";
			this.CCodigo.Name = "CCodigo";
			this.CCodigo.ReadOnly = true;
			// 
			// CNombre
			// 
			this.CNombre.HeaderText = "Titulo";
			this.CNombre.Name = "CNombre";
			this.CNombre.ReadOnly = true;
			// 
			// CTitulo
			// 
			this.CTitulo.HeaderText = "Descripcion";
			this.CTitulo.Name = "CTitulo";
			this.CTitulo.ReadOnly = true;
			// 
			// CTipo
			// 
			this.CTipo.HeaderText = "Tipo";
			this.CTipo.Name = "CTipo";
			this.CTipo.ReadOnly = true;
			// 
			// CFechaF
			// 
			this.CFechaF.HeaderText = "Fecha de Fabricacion";
			this.CFechaF.Name = "CFechaF";
			this.CFechaF.ReadOnly = true;
			// 
			// CPrecio
			// 
			this.CPrecio.HeaderText = "Precio";
			this.CPrecio.Name = "CPrecio";
			this.CPrecio.ReadOnly = true;
			// 
			// CCantidad
			// 
			this.CCantidad.HeaderText = "Cantidad";
			this.CCantidad.Name = "CCantidad";
			this.CCantidad.ReadOnly = true;
			// 
			// DiasPrestamo
			// 
			this.DiasPrestamo.HeaderText = "Dias Presmato";
			this.DiasPrestamo.Name = "DiasPrestamo";
			this.DiasPrestamo.ReadOnly = true;
			// 
			// BotonCerrar
			// 
			this.BotonCerrar.BackColor = System.Drawing.Color.DarkOrchid;
			this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCerrar.FlatAppearance.BorderSize = 0;
			this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCerrar.Location = new System.Drawing.Point(610, 460);
			this.BotonCerrar.Name = "BotonCerrar";
			this.BotonCerrar.Size = new System.Drawing.Size(80, 30);
			this.BotonCerrar.TabIndex = 3;
			this.BotonCerrar.Text = "Cerrar";
			this.BotonCerrar.UseVisualStyleBackColor = false;
			this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrarClick);
			// 
			// LblCodigo
			// 
			this.LblCodigo.AutoSize = true;
			this.LblCodigo.BackColor = System.Drawing.Color.Transparent;
			this.LblCodigo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCodigo.ForeColor = System.Drawing.Color.White;
			this.LblCodigo.Location = new System.Drawing.Point(19, 20);
			this.LblCodigo.Name = "LblCodigo";
			this.LblCodigo.Size = new System.Drawing.Size(104, 32);
			this.LblCodigo.TabIndex = 9;
			this.LblCodigo.Text = "Buscar Titulo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(10, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 32);
			this.label1.TabIndex = 10;
			this.label1.Text = "Buscar Codigo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(20, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 32);
			this.label2.TabIndex = 11;
			this.label2.Text = "Buscar Tipo";
			// 
			// ChBDisponibilidad
			// 
			this.ChBDisponibilidad.BackColor = System.Drawing.Color.Transparent;
			this.ChBDisponibilidad.Checked = true;
			this.ChBDisponibilidad.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChBDisponibilidad.ForeColor = System.Drawing.Color.Snow;
			this.ChBDisponibilidad.Location = new System.Drawing.Point(20, 460);
			this.ChBDisponibilidad.Name = "ChBDisponibilidad";
			this.ChBDisponibilidad.Size = new System.Drawing.Size(104, 24);
			this.ChBDisponibilidad.TabIndex = 12;
			this.ChBDisponibilidad.Text = "Disponibles";
			this.ChBDisponibilidad.UseVisualStyleBackColor = false;
			this.ChBDisponibilidad.CheckedChanged += new System.EventHandler(this.ChBDisponibilidadCheckedChanged);
			// 
			// Modo_Inventario
			// 
			this.Modo_Inventario.BackColor = System.Drawing.Color.Transparent;
			this.Modo_Inventario.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Modo_Inventario.Location = new System.Drawing.Point(260, 450);
			this.Modo_Inventario.Name = "Modo_Inventario";
			this.Modo_Inventario.Size = new System.Drawing.Size(190, 40);
			this.Modo_Inventario.TabIndex = 13;
			this.Modo_Inventario.Text = "Mostrar Inventario";
			this.Modo_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Inventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(700, 500);
			this.Controls.Add(this.Modo_Inventario);
			this.Controls.Add(this.ChBDisponibilidad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BotonCerrar);
			this.Controls.Add(this.DataArticulos);
			this.Controls.Add(this.TxtBuscarCodigo);
			this.Controls.Add(this.TxtBuscarTipo);
			this.Controls.Add(this.TxtBuscarArticulo);
			this.Controls.Add(this.LblCodigo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Inventario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inventario";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.DataArticulos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn DiasPrestamo;
		public System.Windows.Forms.Label Modo_Inventario;
		private System.Windows.Forms.CheckBox ChBDisponibilidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblCodigo;
		private System.Windows.Forms.Button BotonCerrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn CTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
		private System.Windows.Forms.DataGridViewTextBoxColumn CFechaF;
		private System.Windows.Forms.DataGridViewTextBoxColumn CTitulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
		private System.Windows.Forms.DataGridView DataArticulos;
		private System.Windows.Forms.TextBox TxtBuscarCodigo;
		private System.Windows.Forms.TextBox TxtBuscarTipo;
		private System.Windows.Forms.TextBox TxtBuscarArticulo;
	}
}
