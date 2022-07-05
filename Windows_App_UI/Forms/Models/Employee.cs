using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_App_UI.Forms.Models
{
	public class Employee : BaseEntity
	{
		public int EmployeeID { get; set; }	
		public string Title { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime HireDate { get; set; }
		
	}
}
