using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectERP
{
	class master
	{
		private string connection_string = "Server=49.50.174.201;Database=s5414441;Uid=s5414441;Pwd=s5414441;Charset=utf8"; //db 설정

		private static master instance_ = new master();

		public static master GetInstance()
		{
			return instance_;
		}

		private master()
		{
		}

		public void Insert_A_Update(string query)
		{
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				MySqlCommand cmdinsert = new MySqlCommand(query, conn);
				cmdinsert.ExecuteNonQuery();

				conn.Close();
			}
		}

		public DataSet select_work_category(string query)
		{

			MySqlConnection conn = new MySqlConnection(connection_string);
			MySqlDataAdapter adapter = new MySqlDataAdapter("Select " + query + " from work_category", conn);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			return ds;
		}

		public DataSet select_work_category_where(string query, string where,string category)
		{
			MySqlConnection conn = new MySqlConnection(connection_string);
			MySqlDataAdapter adapter = new MySqlDataAdapter("Select " + query + " from work_category WHERE " + where + " = \"" + category + "\"", conn);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			return ds;
		}

		public int excute(string query)
		{
			int result;
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{

				conn.Open();

				MySqlCommand sqlCommand = new MySqlCommand(query, conn);
				result = sqlCommand.ExecuteNonQuery();

				conn.Close();
			}

			return result;
		}

	}
}
