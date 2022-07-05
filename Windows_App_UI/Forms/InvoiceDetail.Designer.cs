namespace Windows_App_UI.Forms
{
	partial class InvoiceDetail
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
			this.GrdInvoice = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.GrdInvoice)).BeginInit();
			this.SuspendLayout();
			// 
			// GrdInvoice
			// 
			this.GrdInvoice.AllowUserToAddRows = false;
			this.GrdInvoice.AllowUserToDeleteRows = false;
			this.GrdInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GrdInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GrdInvoice.Location = new System.Drawing.Point(0, 0);
			this.GrdInvoice.Name = "GrdInvoice";
			this.GrdInvoice.ReadOnly = true;
			this.GrdInvoice.RowHeadersWidth = 51;
			this.GrdInvoice.RowTemplate.Height = 24;
			this.GrdInvoice.Size = new System.Drawing.Size(800, 450);
			this.GrdInvoice.TabIndex = 0;
			// 
			// InvoiceDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.GrdInvoice);
			this.Name = "InvoiceDetail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Detail";
			this.Load += new System.EventHandler(this.InvoiceDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.GrdInvoice)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GrdInvoice;
	}
}