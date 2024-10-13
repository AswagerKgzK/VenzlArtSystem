/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 21/5/2023
 * Hora: 4:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class VentasRealizadas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasRealizadas));
			this.DatosVentas = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BotonCerrar = new System.Windows.Forms.Button();
			this.BotonVerGanancias = new System.Windows.Forms.Button();
			this.BotonMostrarTodo = new System.Windows.Forms.Button();
			this.TxtFecha = new System.Windows.Forms.MaskedTextBox();
			this.BotonMostrarFecha = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DatosVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// DatosVentas
			// 
			this.DatosVentas.AllowUserToAddRows = false;
			this.DatosVentas.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			this.DatosVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DatosVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DatosVentas.BackgroundColor = System.Drawing.Color.MediumPurple;
			this.DatosVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DatosVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DatosVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DatosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DatosVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6});
			this.DatosVentas.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumOrchid;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DatosVentas.DefaultCellStyle = dataGridViewCellStyle5;
			this.DatosVentas.EnableHeadersVisualStyles = false;
			this.DatosVentas.GridColor = System.Drawing.Color.Indigo;
			this.DatosVentas.Location = new System.Drawing.Point(10, 52);
			this.DatosVentas.Name = "DatosVentas";
			this.DatosVentas.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DatosVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.DatosVentas.Size = new System.Drawing.Size(780, 308);
			this.DatosVentas.TabIndex = 1;
			this.DatosVentas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatosVentasCellMouseDoubleClick);
			// 
			// Column1
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column1.HeaderText = "Nro Documento";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
			this.Column2.HeaderText = "Cedula";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Nombre y Apellido";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Telefono";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Total";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Fecha de Venta";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// BotonCerrar
			// 
			this.BotonCerrar.AutoSize = true;
			this.BotonCerrar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCerrar.FlatAppearance.BorderSize = 0;
			this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCerrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonCerrar.ForeColor = System.Drawing.Color.White;
			this.BotonCerrar.Location = new System.Drawing.Point(715, 12);
			this.BotonCerrar.Name = "BotonCerrar";
			this.BotonCerrar.Size = new System.Drawing.Size(75, 31);
			this.BotonCerrar.TabIndex = 2;
			this.BotonCerrar.Text = "Cerrar";
			this.BotonCerrar.UseVisualStyleBackColor = false;
			this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrarClick);
			// 
			// BotonVerGanancias
			// 
			this.BotonVerGanancias.AutoSize = true;
			this.BotonVerGanancias.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonVerGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonVerGanancias.FlatAppearance.BorderSize = 0;
			this.BotonVerGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonVerGanancias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonVerGanancias.ForeColor = System.Drawing.Color.White;
			this.BotonVerGanancias.Location = new System.Drawing.Point(679, 359);
			this.BotonVerGanancias.Name = "BotonVerGanancias";
			this.BotonVerGanancias.Size = new System.Drawing.Size(113, 31);
			this.BotonVerGanancias.TabIndex = 3;
			this.BotonVerGanancias.Text = "Ver ganancias";
			this.BotonVerGanancias.UseVisualStyleBackColor = false;
			this.BotonVerGanancias.Click += new System.EventHandler(this.BotonVerGananciasClick);
			// 
			// BotonMostrarTodo
			// 
			this.BotonMostrarTodo.AutoSize = true;
			this.BotonMostrarTodo.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonMostrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonMostrarTodo.FlatAppearance.BorderSize = 0;
			this.BotonMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonMostrarTodo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonMostrarTodo.ForeColor = System.Drawing.Color.White;
			this.BotonMostrarTodo.Location = new System.Drawing.Point(235, 18);
			this.BotonMostrarTodo.Name = "BotonMostrarTodo";
			this.BotonMostrarTodo.Size = new System.Drawing.Size(111, 31);
			this.BotonMostrarTodo.TabIndex = 4;
			this.BotonMostrarTodo.Text = "Mostrar Todo";
			this.BotonMostrarTodo.UseVisualStyleBackColor = false;
			this.BotonMostrarTodo.Click += new System.EventHandler(this.BotonMostrarTodoClick);
			// 
			// TxtFecha
			// 
			this.TxtFecha.BackColor = System.Drawing.Color.White;
			this.TxtFecha.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtFecha.ForeColor = System.Drawing.Color.Black;
			this.TxtFecha.Location = new System.Drawing.Point(12, 12);
			this.TxtFecha.Mask = "00/00/0000";
			this.TxtFecha.Name = "TxtFecha";
			this.TxtFecha.Size = new System.Drawing.Size(122, 35);
			this.TxtFecha.TabIndex = 5;
			this.TxtFecha.ValidatingType = typeof(System.DateTime);
			this.TxtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaKeyPress);
			// 
			// BotonMostrarFecha
			// 
			this.BotonMostrarFecha.AutoSize = true;
			this.BotonMostrarFecha.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonMostrarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonMostrarFecha.FlatAppearance.BorderSize = 0;
			this.BotonMostrarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonMostrarFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonMostrarFecha.ForeColor = System.Drawing.Color.White;
			this.BotonMostrarFecha.Location = new System.Drawing.Point(140, 17);
			this.BotonMostrarFecha.Name = "BotonMostrarFecha";
			this.BotonMostrarFecha.Size = new System.Drawing.Size(89, 31);
			this.BotonMostrarFecha.TabIndex = 6;
			this.BotonMostrarFecha.Text = "Mostrar";
			this.BotonMostrarFecha.UseVisualStyleBackColor = false;
			this.BotonMostrarFecha.Click += new System.EventHandler(this.BotonMostrarFechaClick);
			// 
			// VentasRealizadas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(800, 400);
			this.Controls.Add(this.BotonMostrarFecha);
			this.Controls.Add(this.TxtFecha);
			this.Controls.Add(this.BotonMostrarTodo);
			this.Controls.Add(this.BotonVerGanancias);
			this.Controls.Add(this.BotonCerrar);
			this.Controls.Add(this.DatosVentas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "VentasRealizadas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VentasRealizadas";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.DatosVentas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BotonMostrarFecha;
		private System.Windows.Forms.MaskedTextBox TxtFecha;
		private System.Windows.Forms.Button BotonMostrarTodo;
		private System.Windows.Forms.Button BotonVerGanancias;
		private System.Windows.Forms.Button BotonCerrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView DatosVentas;
	}
}
