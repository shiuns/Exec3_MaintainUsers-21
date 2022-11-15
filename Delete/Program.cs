using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"Delete From Users_homework WHERE Account <= @Account ";
			var dbHelper = new SqlDbHelper("default");
			try
			{
				var parameters = new SqlParameterBuilder()
					.AddNVarchar("Account", 50, "ccc")
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
