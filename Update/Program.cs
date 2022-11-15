using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"Update Users_homework SET Name=@Name, Account=@Account, Password=@Password WHERE Id=@Id";
			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("Name", 50, "Mkio")
					.AddNVarchar("Account", 50, "qqqqq")
					.AddNVarchar("Password", 50, "saaaa")
					.AddInt("id", 2)
					.Build();

				dbHelper.ExecuteNonQuery(sql, parameters);

				Console.WriteLine("記錄已更新");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"操作失敗, 原因 :{ex.Message}");
			}
		}
	}
}
