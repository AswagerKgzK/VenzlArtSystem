/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 21/5/2023
 * Hora: 1:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class FormaPago
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPago));
			this.BotonDebito = new System.Windows.Forms.Button();
			this.BotonCredito = new System.Windows.Forms.Button();
			this.BotonPagoM = new System.Windows.Forms.Button();
			this.BotonDivisas = new System.Windows.Forms.Button();
			this.BotonRegresar = new System.Windows.Forms.Button();
			this.BotonEfectivo = new System.Windows.Forms.Button();
			this.BotonCestaT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BotonDebito
			// 
			this.BotonDebito.AutoSize = true;
			this.BotonDebito.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonDebito.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonDebito.FlatAppearance.BorderSize = 0;
			this.BotonDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonDebito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonDebito.ForeColor = System.Drawing.Color.White;
			this.BotonDebito.Location = new System.Drawing.Point(110, 20);
			this.BotonDebito.Name = "BotonDebito";
			this.BotonDebito.Size = new System.Drawing.Size(70, 31);
			this.BotonDebito.TabIndex = 0;
			this.BotonDebito.Text = "Debito";
			this.BotonDebito.UseVisualStyleBackColor = false;
			this.BotonDebito.Click += new System.EventHandler(this.BotonDebitoClick);
			// 
			// BotonCredito
			// 
			this.BotonCredito.AutoSize = true;
			this.BotonCredito.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCredito.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCredito.FlatAppearance.BorderSize = 0;
			this.BotonCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCredito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonCredito.ForeColor = System.Drawing.Color.White;
			this.BotonCredito.Location = new System.Drawing.Point(10, 100);
			this.BotonCredito.Name = "BotonCredito";
			this.BotonCredito.Size = new System.Drawing.Size(70, 31);
			this.BotonCredito.TabIndex = 1;
			this.BotonCredito.Text = "Credito";
			this.BotonCredito.UseVisualStyleBackColor = false;
			this.BotonCredito.Click += new System.EventHandler(this.BotonCreditoClick);
			// 
			// BotonPagoM
			// 
			this.BotonPagoM.AutoSize = true;
			this.BotonPagoM.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonPagoM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonPagoM.FlatAppearance.BorderSize = 0;
			this.BotonPagoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonPagoM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonPagoM.ForeColor = System.Drawing.Color.White;
			this.BotonPagoM.Location = new System.Drawing.Point(10, 60);
			this.BotonPagoM.Name = "BotonPagoM";
			this.BotonPagoM.Size = new System.Drawing.Size(96, 31);
			this.BotonPagoM.TabIndex = 2;
			this.BotonPagoM.Text = "Pago Movil";
			this.BotonPagoM.UseVisualStyleBackColor = false;
			this.BotonPagoM.Click += new System.EventHandler(this.BotonPagoMClick);
			// 
			// BotonDivisas
			// 
			this.BotonDivisas.AutoSize = true;
			this.BotonDivisas.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonDivisas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonDivisas.FlatAppearance.BorderSize = 0;
			this.BotonDivisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonDivisas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonDivisas.ForeColor = System.Drawing.Color.White;
			this.BotonDivisas.Location = new System.Drawing.Point(120, 60);
			this.BotonDivisas.Name = "BotonDivisas";
			this.BotonDivisas.Size = new System.Drawing.Size(70, 31);
			this.BotonDivisas.TabIndex = 3;
			this.BotonDivisas.Text = "Divisas";
			this.BotonDivisas.UseVisualStyleBackColor = false;
			this.BotonDivisas.Click += new System.EventHandler(this.BotonDivisasClick);
			// 
			// BotonRegresar
			// 
			this.BotonRegresar.AutoSize = true;
			this.BotonRegresar.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonRegresar.FlatAppearance.BorderSize = 0;
			this.BotonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonRegresar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonRegresar.ForeColor = System.Drawing.Color.White;
			this.BotonRegresar.Location = new System.Drawing.Point(67, 161);
			this.BotonRegresar.Name = "BotonRegresar";
			this.BotonRegresar.Size = new System.Drawing.Size(77, 31);
			this.BotonRegresar.TabIndex = 4;
			this.BotonRegresar.Text = "Regresar";
			this.BotonRegresar.UseVisualStyleBackColor = false;
			this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresarClick);
			// 
			// BotonEfectivo
			// 
			this.BotonEfectivo.AutoSize = true;
			this.BotonEfectivo.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonEfectivo.FlatAppearance.BorderSize = 0;
			this.BotonEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonEfectivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonEfectivo.ForeColor = System.Drawing.Color.White;
			this.BotonEfectivo.Location = new System.Drawing.Point(20, 20);
			this.BotonEfectivo.Name = "BotonEfectivo";
			this.BotonEfectivo.Size = new System.Drawing.Size(75, 31);
			this.BotonEfectivo.TabIndex = 5;
			this.BotonEfectivo.Text = "Efectivo";
			this.BotonEfectivo.UseVisualStyleBackColor = false;
			this.BotonEfectivo.Click += new System.EventHandler(this.BotonEfectivoClick);
			// 
			// BotonCestaT
			// 
			this.BotonCestaT.AutoSize = true;
			this.BotonCestaT.BackColor = System.Drawing.Color.DarkViolet;
			this.BotonCestaT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCestaT.FlatAppearance.BorderSize = 0;
			this.BotonCestaT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCestaT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.BotonCestaT.ForeColor = System.Drawing.Color.White;
			this.BotonCestaT.Location = new System.Drawing.Point(90, 100);
			this.BotonCestaT.Name = "BotonCestaT";
			this.BotonCestaT.Size = new System.Drawing.Size(103, 31);
			this.BotonCestaT.TabIndex = 6;
			this.BotonCestaT.Text = "CestaTickets";
			this.BotonCestaT.UseVisualStyleBackColor = false;
			this.BotonCestaT.Click += new System.EventHandler(this.BotonCestaTClick);
			// 
			// FormaPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(205, 205);
			this.Controls.Add(this.BotonCestaT);
			this.Controls.Add(this.BotonEfectivo);
			this.Controls.Add(this.BotonRegresar);
			this.Controls.Add(this.BotonDivisas);
			this.Controls.Add(this.BotonPagoM);
			this.Controls.Add(this.BotonCredito);
			this.Controls.Add(this.BotonDebito);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormaPago";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormaPago";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BotonCestaT;
		private System.Windows.Forms.Button BotonEfectivo;
		private System.Windows.Forms.Button BotonRegresar;
		private System.Windows.Forms.Button BotonDivisas;
		private System.Windows.Forms.Button BotonPagoM;
		private System.Windows.Forms.Button BotonCredito;
		private System.Windows.Forms.Button BotonDebito;
	}
}
