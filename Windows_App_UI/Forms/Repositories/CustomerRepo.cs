using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_App_UI.Forms.Models;

namespace Windows_App_UI.Forms.Repositories
{
	public class CustomerRepo : BaseRepository
	{
		public List<Customer> GetAllByEmployeeId(int EmployeeId)
		{
			List<Customer> result = new List<Customer>();
			var parameters = new { employeeId = EmployeeId };
			result = con.Query<Customer>("select * from customers where SupportRepId = @EmployeeId", parameters).ToList();

			return result;

		}
	}
}
