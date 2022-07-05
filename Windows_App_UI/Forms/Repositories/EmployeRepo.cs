using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_App_UI.Forms.Models;

namespace Windows_App_UI.Forms.Repositories
{
	public class EmployeRepo : BaseRepository
	{
		public EmployeRepo()
		{

		}

		public List<Employee> GetAll()
		{
			List<Employee> DataList = new List<Employee>();
			DataList = con.Query<Employee>("select * from employees").ToList();
			return DataList;
		}

		public Employee GetById(int Id)
		{
			Employee DataList = new Employee();
			var parameters = new { employeeId = Id };
			DataList = con.QueryFirstOrDefault<Employee>("select * from employees where EmployeeId = @employeeId", parameters);
			return DataList;

		}

		public void UpdateEmployee(string Phone, String Fax, string EMail, int EmployeeId)
		{
			var parameters = new
			{
				Phone = Phone,
				Fax = Fax,
				EMail = EMail,
				EmployeeId = EmployeeId,
			};
			var result = con.Execute("update employees set Phone = @Phone, Fax=@Fax, EMail = @Email WHERE EmployeeId = @EmployeeId", parameters);
			
		}
	}
}
