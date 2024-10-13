using System;
using System.Drawing;
using System.Windows.Forms;

namespace VenzlArtSystem
{
	public partial class FormaPago : Form
	{
		public string FormadePago;
		
		public FormaPago()
		{
			InitializeComponent();
		}
		
		void BotonEfectivoClick(object sender, EventArgs e)
		{
			FormadePago = BotonEfectivo.Text;
			Dispose();
		}
		
		void BotonDebitoClick(object sender, EventArgs e)
		{
			FormadePago = BotonDebito.Text;
			Dispose();
		}
		
		void BotonPagoMClick(object sender, EventArgs e)
		{
			FormadePago = BotonPagoM.Text;
			Dispose();
		}
		
		void BotonDivisasClick(object sender, EventArgs e)
		{
			FormadePago = BotonDivisas.Text;
			Dispose();
		}
		
		void BotonCreditoClick(object sender, EventArgs e)
		{
			FormadePago = BotonCredito.Text;
			Dispose();
		}
		
		void BotonCestaTClick(object sender, EventArgs e)
		{
			FormadePago = BotonCestaT.Text;
			Dispose();
		}
		
		void BotonRegresarClick(object sender, EventArgs e)
		{
			FormadePago = BotonRegresar.Text;
			Dispose();
		}
	}
}
