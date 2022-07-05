namespace Windows_App_UI.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Çalışanlar = new System.Windows.Forms.GroupBox();
			this.GrdEmployee = new System.Windows.Forms.DataGridView();
			this.Çalışanlar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GrdEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// Çalışanlar
			// 
			this.Çalışanlar.Controls.Add(this.GrdEmployee);
			this.Çalışanlar.Location = new System.Drawing.Point(1, 12);
			this.Çalışanlar.Name = "Çalışanlar";
			this.Çalışanlar.Size = new System.Drawing.Size(796, 412);
			this.Çalışanlar.TabIndex = 0;
			this.Çalışanlar.TabStop = false;
			this.Çalışanlar.Text = "Çalışanlar";
			// 
			// GrdEmployee
			// 
			this.GrdEmployee.AllowUserToAddRows = false;
			this.GrdEmployee.AllowUserToDeleteRows = false;
			this.GrdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GrdEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GrdEmployee.Location = new System.Drawing.Point(3, 18);
			this.GrdEmployee.Name = "GrdEmployee";
			this.GrdEmployee.ReadOnly = true;
			this.GrdEmployee.RowHeadersWidth = 51;
			this.GrdEmployee.RowTemplate.Height = 24;
			this.GrdEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GrdEmployee.Size = new System.Drawing.Size(790, 391);
			this.GrdEmployee.TabIndex = 0;
			this.GrdEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdEmployee_CellDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Çalışanlar);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "App";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Çalışanlar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GrdEmployee)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox Çalışanlar;
		private System.Windows.Forms.DataGridView GrdEmployee;
	}
}