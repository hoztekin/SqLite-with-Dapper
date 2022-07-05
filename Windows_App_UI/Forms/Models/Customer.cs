using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_App_UI.Forms.Models
{
	public class Customer : BaseEntity
	{
		public int CustomerId { get; set; }
		public string Company { get; set; }
	}
}
