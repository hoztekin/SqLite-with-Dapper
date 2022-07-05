using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_App_UI.Forms.Models;

namespace Windows_App_UI.Forms.Repositories
{
	public class InvoiceRepo : BaseRepository
	{
		public List<Invoice> GetAll(int CustomerId)
		{
			List<Invoice> DataInvoices = new List<Invoice>();
			var parameters = new { customerId = CustomerId };
			DataInvoices = con.Query<Invoice>("select * from invoices where CustomerId = @CustomerId", parameters).ToList();
			return DataInvoices;
		}
		
	}
}
