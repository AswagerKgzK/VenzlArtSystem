/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 21/5/2023
 * Hora: 5:50 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class Factura
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.LCedula = new System.Windows.Forms.Label();
			this.LNombreApellido = new System.Windows.Forms.Label();
			this.LTelefonoR = new System.Windows.Forms.Label();
			this.LCorreo = new System.Windows.Forms.Label();
			this.LDireccion = new System.Windows.Forms.Label();
			this.LCodigo = new System.Windows.Forms.Label();
			this.LFechaEmision = new System.Windows.Forms.Label();
			this.DatosLista = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LTotal = new System.Windows.Forms.Label();
			this.LModoPago = new System.Windows.Forms.Label();
			this.LTelefonoM = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DatosLista)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.label1.Location = new System.Drawing.Point(20, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Datos del Cliente:";
			// 
			// LCedula
			// 
			this.LCedula.AutoSize = true;
			this.LCedula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LCedula.Location = new System.Drawing.Point(20, 70);
			this.LCedula.Name = "LCedula";
			this.LCedula.Size = new System.Drawing.Size(55, 19);
			this.LCedula.TabIndex = 1;
			this.LCedula.Text = "Cedula";
			// 
			// LNombreApellido
			// 
			this.LNombreApellido.AutoSize = true;
			this.LNombreApellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LNombreApellido.Location = new System.Drawing.Point(20, 100);
			this.LNombreApellido.Name = "LNombreApellido";
			this.LNombreApellido.Size = new System.Drawing.Size(126, 19);
			this.LNombreApellido.TabIndex = 2;
			this.LNombreApellido.Text = "Nombre y apellido";
			// 
			// LTelefonoR
			// 
			this.LTelefonoR.AutoSize = true;
			this.LTelefonoR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LTelefonoR.Location = new System.Drawing.Point(200, 190);
			this.LTelefonoR.Name = "LTelefonoR";
			this.LTelefonoR.Size = new System.Drawing.Size(70, 19);
			this.LTelefonoR.TabIndex = 3;
			this.LTelefonoR.Text = "Telefonos";
			// 
			// LCorreo
			// 
			this.LCorreo.AutoSize = true;
			this.LCorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LCorreo.Location = new System.Drawing.Point(20, 130);
			this.LCorreo.Name = "LCorreo";
			this.LCorreo.Size = new System.Drawing.Size(54, 19);
			this.LCorreo.TabIndex = 4;
			this.LCorreo.Text = "Correo";
			// 
			// LDireccion
			// 
			this.LDireccion.AutoSize = true;
			this.LDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LDireccion.Location = new System.Drawing.Point(20, 160);
			this.LDireccion.Name = "LDireccion";
			this.LDireccion.Size = new System.Drawing.Size(70, 19);
			this.LDireccion.TabIndex = 5;
			this.LDireccion.Text = "Direccion";
			// 
			// LCodigo
			// 
			this.LCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LCodigo.Location = new System.Drawing.Point(230, 10);
			this.LCodigo.Name = "LCodigo";
			this.LCodigo.Size = new System.Drawing.Size(150, 30);
			this.LCodigo.TabIndex = 6;
			this.LCodigo.Text = "Codigo";
			this.LCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LFechaEmision
			// 
			this.LFechaEmision.AutoSize = true;
			this.LFechaEmision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LFechaEmision.Location = new System.Drawing.Point(200, 40);
			this.LFechaEmision.Name = "LFechaEmision";
			this.LFechaEmision.Size = new System.Drawing.Size(105, 19);
			this.LFechaEmision.TabIndex = 7;
			this.LFechaEmision.Text = "Fecha Emision";
			// 
			// DatosLista
			// 
			this.DatosLista.AllowUserToResizeColumns = false;
			this.DatosLista.AllowUserToResizeRows = false;
			this.DatosLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DatosLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.DatosLista.BackgroundColor = System.Drawing.Color.White;
			this.DatosLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DatosLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DatosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DatosLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DatosLista.DefaultCellStyle = dataGridViewCellStyle4;
			this.DatosLista.Location = new System.Drawing.Point(-40, 220);
			this.DatosLista.Name = "DatosLista";
			this.DatosLista.ReadOnly = true;
			this.DatosLista.Size = new System.Drawing.Size(430, 330);
			this.DatosLista.TabIndex = 8;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Titulo";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Devolucion";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Cantidad";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Total";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// LTotal
			// 
			this.LTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LTotal.Location = new System.Drawing.Point(280, 560);
			this.LTotal.Name = "LTotal";
			this.LTotal.Size = new System.Drawing.Size(100, 20);
			this.LTotal.TabIndex = 9;
			this.LTotal.Text = "Total";
			this.LTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LModoPago
			// 
			this.LModoPago.AutoSize = true;
			this.LModoPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LModoPago.Location = new System.Drawing.Point(30, 560);
			this.LModoPago.Name = "LModoPago";
			this.LModoPago.Size = new System.Drawing.Size(80, 19);
			this.LModoPago.TabIndex = 10;
			this.LModoPago.Text = "ModoPago";
			// 
			// LTelefonoM
			// 
			this.LTelefonoM.AutoSize = true;
			this.LTelefonoM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.LTelefonoM.Location = new System.Drawing.Point(20, 190);
			this.LTelefonoM.Name = "LTelefonoM";
			this.LTelefonoM.Size = new System.Drawing.Size(70, 19);
			this.LTelefonoM.TabIndex = 11;
			this.LTelefonoM.Text = "Telefonos";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Factura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(400, 600);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.LTelefonoM);
			this.Controls.Add(this.LModoPago);
			this.Controls.Add(this.LTotal);
			this.Controls.Add(this.DatosLista);
			this.Controls.Add(this.LFechaEmision);
			this.Controls.Add(this.LCodigo);
			this.Controls.Add(this.LDireccion);
			this.Controls.Add(this.LCorreo);
			this.Controls.Add(this.LTelefonoR);
			this.Controls.Add(this.LNombreApellido);
			this.Controls.Add(this.LCedula);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Factura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Factura";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.DatosLista)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label LTelefonoM;
		private System.Windows.Forms.Label LModoPago;
		private System.Windows.Forms.Label LTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		public System.Windows.Forms.DataGridView DatosLista;
		private System.Windows.Forms.Label LFechaEmision;
		private System.Windows.Forms.Label LCodigo;
		private System.Windows.Forms.Label LDireccion;
		private System.Windows.Forms.Label LCorreo;
		private System.Windows.Forms.Label LTelefonoR;
		private System.Windows.Forms.Label LNombreApellido;
		private System.Windows.Forms.Label LCedula;
		private System.Windows.Forms.Label label1;
	}
}
