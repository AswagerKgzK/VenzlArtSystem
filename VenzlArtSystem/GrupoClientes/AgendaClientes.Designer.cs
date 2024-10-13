/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 18/5/2023
 * Hora: 3:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class AgendaClientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaClientes));
			this.Modo_Cliente = new System.Windows.Forms.Label();
			this.BotonCerrar = new System.Windows.Forms.Button();
			this.DataClientes = new System.Windows.Forms.DataGridView();
			this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CFechaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TxtBuscarCedula = new System.Windows.Forms.TextBox();
			this.TxtBuscarNombre = new System.Windows.Forms.TextBox();
			this.LblCodigo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DataClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// Modo_Cliente
			// 
			this.Modo_Cliente.BackColor = System.Drawing.Color.Transparent;
			this.Modo_Cliente.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Modo_Cliente.ForeColor = System.Drawing.Color.Black;
			this.Modo_Cliente.Location = new System.Drawing.Point(260, 440);
			this.Modo_Cliente.Name = "Modo_Cliente";
			this.Modo_Cliente.Size = new System.Drawing.Size(190, 40);
			this.Modo_Cliente.TabIndex = 21;
			this.Modo_Cliente.Text = "Mostrar Clientes";
			this.Modo_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BotonCerrar
			// 
			this.BotonCerrar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCerrar.FlatAppearance.BorderSize = 0;
			this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCerrar.Location = new System.Drawing.Point(610, 450);
			this.BotonCerrar.Name = "BotonCerrar";
			this.BotonCerrar.Size = new System.Drawing.Size(80, 30);
			this.BotonCerrar.TabIndex = 18;
			this.BotonCerrar.Text = "Cerrar";
			this.BotonCerrar.UseVisualStyleBackColor = false;
			this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrarClick);
			// 
			// DataClientes
			// 
			this.DataClientes.AllowUserToAddRows = false;
			this.DataClientes.AllowUserToDeleteRows = false;
			this.DataClientes.AllowUserToResizeColumns = false;
			this.DataClientes.AllowUserToResizeRows = false;
			this.DataClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataClientes.BackgroundColor = System.Drawing.Color.MediumPurple;
			this.DataClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DataClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.DataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.CCodigo,
									this.CNombre,
									this.CTitulo,
									this.CTipo,
									this.CFechaF,
									this.CPrecio});
			this.DataClientes.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataClientes.DefaultCellStyle = dataGridViewCellStyle2;
			this.DataClientes.EnableHeadersVisualStyles = false;
			this.DataClientes.GridColor = System.Drawing.Color.Black;
			this.DataClientes.Location = new System.Drawing.Point(20, 116);
			this.DataClientes.MultiSelect = false;
			this.DataClientes.Name = "DataClientes";
			this.DataClientes.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DataClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataClientes.ShowEditingIcon = false;
			this.DataClientes.Size = new System.Drawing.Size(660, 307);
			this.DataClientes.TabIndex = 17;
			this.DataClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClientesCellDoubleClick);
			// 
			// CCodigo
			// 
			this.CCodigo.HeaderText = "Cedula";
			this.CCodigo.Name = "CCodigo";
			this.CCodigo.ReadOnly = true;
			// 
			// CNombre
			// 
			this.CNombre.HeaderText = "Nombre y Apellido";
			this.CNombre.Name = "CNombre";
			this.CNombre.ReadOnly = true;
			// 
			// CTitulo
			// 
			this.CTitulo.HeaderText = "Correo";
			this.CTitulo.Name = "CTitulo";
			this.CTitulo.ReadOnly = true;
			// 
			// CTipo
			// 
			this.CTipo.HeaderText = "Direccion";
			this.CTipo.Name = "CTipo";
			this.CTipo.ReadOnly = true;
			// 
			// CFechaF
			// 
			this.CFechaF.HeaderText = "Fecha de Nacimiento";
			this.CFechaF.Name = "CFechaF";
			this.CFechaF.ReadOnly = true;
			// 
			// CPrecio
			// 
			this.CPrecio.HeaderText = "Telefonos";
			this.CPrecio.Name = "CPrecio";
			this.CPrecio.ReadOnly = true;
			// 
			// TxtBuscarCedula
			// 
			this.TxtBuscarCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBuscarCedula.Location = new System.Drawing.Point(130, 60);
			this.TxtBuscarCedula.Name = "TxtBuscarCedula";
			this.TxtBuscarCedula.Size = new System.Drawing.Size(530, 30);
			this.TxtBuscarCedula.TabIndex = 16;
			this.TxtBuscarCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarCedulaKeyPress);
			// 
			// TxtBuscarNombre
			// 
			this.TxtBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBuscarNombre.Location = new System.Drawing.Point(130, 20);
			this.TxtBuscarNombre.Name = "TxtBuscarNombre";
			this.TxtBuscarNombre.Size = new System.Drawing.Size(530, 30);
			this.TxtBuscarNombre.TabIndex = 14;
			this.TxtBuscarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarNombreKeyPress);
			// 
			// LblCodigo
			// 
			this.LblCodigo.AutoSize = true;
			this.LblCodigo.BackColor = System.Drawing.Color.Transparent;
			this.LblCodigo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCodigo.Location = new System.Drawing.Point(10, 20);
			this.LblCodigo.Name = "LblCodigo";
			this.LblCodigo.Size = new System.Drawing.Size(119, 32);
			this.LblCodigo.TabIndex = 19;
			this.LblCodigo.Text = "Buscar Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 32);
			this.label1.TabIndex = 20;
			this.label1.Text = "Buscar Cedula";
			// 
			// AgendaClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(699, 493);
			this.Controls.Add(this.Modo_Cliente);
			this.Controls.Add(this.BotonCerrar);
			this.Controls.Add(this.DataClientes);
			this.Controls.Add(this.TxtBuscarCedula);
			this.Controls.Add(this.TxtBuscarNombre);
			this.Controls.Add(this.LblCodigo);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AgendaClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AgendaClientes";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.DataClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblCodigo;
		private System.Windows.Forms.TextBox TxtBuscarNombre;
		private System.Windows.Forms.TextBox TxtBuscarCedula;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
		private System.Windows.Forms.DataGridViewTextBoxColumn CFechaF;
		private System.Windows.Forms.DataGridViewTextBoxColumn CTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CTitulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
		private System.Windows.Forms.DataGridView DataClientes;
		private System.Windows.Forms.Button BotonCerrar;
		public System.Windows.Forms.Label Modo_Cliente;
	}
}
