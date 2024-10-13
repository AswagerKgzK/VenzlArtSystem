/*
 * Creado por SharpDevelop.
 * Usuario: Bradd
 * Fecha: 24/4/2023
 * Hora: 8:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace VenzlArtSystem
{
	partial class MensajeAviso
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeAviso));
			this.LblAviso = new System.Windows.Forms.Label();
			this.LblMensaje = new System.Windows.Forms.Label();
			this.Boton1 = new System.Windows.Forms.Button();
			this.Boton2 = new System.Windows.Forms.Button();
			this.Boton3 = new System.Windows.Forms.Button();
			this.BotonCerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblAviso
			// 
			this.LblAviso.BackColor = System.Drawing.Color.Plum;
			this.LblAviso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblAviso.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAviso.Location = new System.Drawing.Point(10, 10);
			this.LblAviso.Name = "LblAviso";
			this.LblAviso.Size = new System.Drawing.Size(290, 30);
			this.LblAviso.TabIndex = 0;
			this.LblAviso.Text = "Informacion";
			this.LblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblMensaje
			// 
			this.LblMensaje.BackColor = System.Drawing.Color.LavenderBlush;
			this.LblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblMensaje.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblMensaje.Location = new System.Drawing.Point(20, 60);
			this.LblMensaje.Name = "LblMensaje";
			this.LblMensaje.Size = new System.Drawing.Size(310, 130);
			this.LblMensaje.TabIndex = 1;
			this.LblMensaje.Text = "Mensaje";
			this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Boton1
			// 
			this.Boton1.BackColor = System.Drawing.Color.Plum;
			this.Boton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Boton1.FlatAppearance.BorderSize = 0;
			this.Boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Boton1.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Boton1.Location = new System.Drawing.Point(10, 210);
			this.Boton1.Name = "Boton1";
			this.Boton1.Size = new System.Drawing.Size(90, 30);
			this.Boton1.TabIndex = 2;
			this.Boton1.Text = "Boton1";
			this.Boton1.UseVisualStyleBackColor = false;
			this.Boton1.Visible = false;
			this.Boton1.Click += new System.EventHandler(this.Boton1Click);
			// 
			// Boton2
			// 
			this.Boton2.BackColor = System.Drawing.Color.Plum;
			this.Boton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Boton2.FlatAppearance.BorderSize = 0;
			this.Boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Boton2.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Boton2.Location = new System.Drawing.Point(130, 210);
			this.Boton2.Name = "Boton2";
			this.Boton2.Size = new System.Drawing.Size(90, 30);
			this.Boton2.TabIndex = 3;
			this.Boton2.Text = "Boton2";
			this.Boton2.UseVisualStyleBackColor = false;
			this.Boton2.Click += new System.EventHandler(this.Boton2Click);
			// 
			// Boton3
			// 
			this.Boton3.BackColor = System.Drawing.Color.Plum;
			this.Boton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Boton3.FlatAppearance.BorderSize = 0;
			this.Boton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Boton3.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Boton3.Location = new System.Drawing.Point(250, 210);
			this.Boton3.Name = "Boton3";
			this.Boton3.Size = new System.Drawing.Size(90, 30);
			this.Boton3.TabIndex = 4;
			this.Boton3.Text = "Boton3";
			this.Boton3.UseVisualStyleBackColor = false;
			this.Boton3.Visible = false;
			this.Boton3.Click += new System.EventHandler(this.Boton3Click);
			// 
			// BotonCerrar
			// 
			this.BotonCerrar.BackColor = System.Drawing.Color.Plum;
			this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BotonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BotonCerrar.FlatAppearance.BorderSize = 0;
			this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonCerrar.Location = new System.Drawing.Point(310, 10);
			this.BotonCerrar.Name = "BotonCerrar";
			this.BotonCerrar.Size = new System.Drawing.Size(30, 30);
			this.BotonCerrar.TabIndex = 5;
			this.BotonCerrar.Text = "X";
			this.BotonCerrar.UseVisualStyleBackColor = false;
			this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrarClick);
			// 
			// MensajeAviso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(350, 250);
			this.Controls.Add(this.BotonCerrar);
			this.Controls.Add(this.Boton3);
			this.Controls.Add(this.Boton2);
			this.Controls.Add(this.Boton1);
			this.Controls.Add(this.LblMensaje);
			this.Controls.Add(this.LblAviso);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MensajeAviso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Personalizaciones";
			this.TopMost = true;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button BotonCerrar;
		private System.Windows.Forms.Button Boton3;
		private System.Windows.Forms.Button Boton2;
		private System.Windows.Forms.Button Boton1;
		private System.Windows.Forms.Label LblMensaje;
		private System.Windows.Forms.Label LblAviso;
	}
}
