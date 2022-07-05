using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_App_UI.Forms.Repositories
{
	public class BaseRepository : IDisposable
	{
		public SQLiteConnection con;

		public BaseRepository()
		{
			con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString);
		}
		public void Dispose()
		{
			GC.SuppressFinalize(this);	
		}
	}
}
