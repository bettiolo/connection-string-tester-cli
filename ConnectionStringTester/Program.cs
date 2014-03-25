using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConnectionStringTester
{
	class Program
	{
		static void Main(string[] args)
		{
			SqlConnection conn = null;
			Console.WriteLine("Insert connection string:");
			var connectionString = Console.ReadLine();
			try
			{
				conn = new SqlConnection(connectionString);
				conn.Open();
				Console.WriteLine("Works!");
			}
			catch (SqlException sqlE)
			{
				Console.WriteLine("Error:");
				Console.Write(sqlE.Message);
				Console.WriteLine("---");
			}
			finally
			{
				if (conn != null) conn.Dispose();
			}
			Console.WriteLine("Press any key to exit.");
			Console.ReadLine();
		}
	}
}
