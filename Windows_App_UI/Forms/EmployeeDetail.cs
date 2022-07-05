using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_App_UI.Forms.Models;
using Windows_App_UI.Forms.Repositories;

namespace Windows_App_UI.Forms
{
	public partial class EmployeeDetail : Form
	{
		int EmployeeId;
		public EmployeeDetail(int EmployeeId)
		{
			InitializeComponent();
			this.EmployeeId = EmployeeId;
		}

		public void EmployeeDetail_Load(object sender, EventArgs e)
		{
			GetEmployeeById();
			GetCustomerByEmployeeId();
		}
		void GetEmployeeById()
		{
			using (EmployeRepo employeRepo = new EmployeRepo())
			{
				Employee DataSource = employeRepo.GetById(EmployeeId);

				if (DataSource!=null)
				{
					TitleBox.Text = DataSource.Title;
					txtFirstName.Text = DataSource.FirstName;
					txtLastName.Text = DataSource.LastName;
					txtBirthDate.Text = DataSource.BirthDate.ToShortDateString();
					txtHireDate.Text = DataSource.HireDate.ToShortDateString();

					textCountry.Text = DataSource.Country;
					txtCity.Text = DataSource.City;
					txtAddress.Text = DataSource.Address;

					txtPhone.Text = DataSource.Phone;
					txtFax.Text = DataSource.Fax;
					txtEMail.Text = DataSource.EMail;					
				}
				
			}
		}

		void GetCustomerByEmployeeId() 
		{
			using (CustomerRepo CustomerRepo = new CustomerRepo())
			{
				dataGridView1.DataSource = CustomerRepo.GetAllByEmployeeId(EmployeeId);
			}
		}

		public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int CustomerId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
			InvoiceDetail InvoiceDetailForm = new InvoiceDetail(CustomerId);
			InvoiceDetailForm.ShowDialog();
		}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			using (EmployeRepo employeRepo = new EmployeRepo())
			{
				
				employeRepo.UpdateEmployee(txtPhone.Text, txtFax.Text, txtEMail.Text, EmployeeId);
				
			}
		}
	}
}
