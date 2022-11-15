using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var dbHelper = new SqlDbHelper("default");
			string sql = "SELECT Id,Name From Users_homework WHERE Id>@Id ORDER BY Id ";
			try
			{
				var parameters = new SqlParameterBuilder().AddInt("id", 0).Build();
				DataTable news = dbHelper.Select(sql, parameters);
				foreach (DataRow row in news.Rows)
				{
					int id = row.Field<int>("id");
					string Name = row.Field<string>("title");

					Console.WriteLine($"Id={id}, Name={Name}");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"操作失敗, 原因 :{ex.Message}");
			}
		}
	}
}
