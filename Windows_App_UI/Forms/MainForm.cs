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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public void MainForm_Load(object sender, EventArgs e)
		{
			GetEmployees();
		}

		void GetEmployees() 
		{
			using (EmployeRepo employe = new EmployeRepo())
			{
				GrdEmployee.DataSource = employe.GetAll();
			}
		}

		private void GrdEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var EmployeeId = (int)GrdEmployee.Rows[e.RowIndex].Cells[0].Value;
			EmployeeDetail employeeDetail = new EmployeeDetail(EmployeeId);
			employeeDetail.ShowDialog();

		}
	}
}
