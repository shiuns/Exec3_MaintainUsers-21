using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"insert into Users_homework(Name, Account, Password, Height)
						values
						(@Name, @Account, @Password, @Height)";
			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("Name", 50, "Mike")
					.AddNVarchar("Account", 50, "aaa")
					.AddNVarchar("Password", 50, "lala")
					.AddInt("Height", 165)
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);

				Console.WriteLine("記錄已新增");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"操作失敗, 原因 :{ex.Message}");
			}
		}
	}
}
