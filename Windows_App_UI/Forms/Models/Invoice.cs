using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_App_UI.Forms.Models
{
	public class Invoice : BaseEntity
	{
		public int InvoiceId { get; set; }
		public int CustomerId { get; set; }
		public DateTime InvoiceDate { get; set; }
		public string BillingAddress { get; set; }
		public string BillingCity { get; set; }
		public decimal Total { get; set; }
	}
}
