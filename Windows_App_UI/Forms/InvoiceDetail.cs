using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_App_UI.Forms.Repositories;

namespace Windows_App_UI.Forms
{
	public partial class InvoiceDetail : Form
	{
		int CustomerId = 0;
		public InvoiceDetail(int CustomerId)
		{
			InitializeComponent();
			this.CustomerId = CustomerId;
		}

		public void InvoiceDetail_Load(object sender, EventArgs e)
		{
			using (InvoiceRepo InvoiceRepo = new InvoiceRepo())
			{
				GrdInvoice.DataSource = InvoiceRepo.GetAll(CustomerId);
			}
		}
	}
}
