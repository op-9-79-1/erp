using System.Data;
using MySql.Data.MySqlClient;

namespace ProjectERP
{
	class master
	{
		private string connection_string = "Server=49.50.174.201;Database=s5414441;Uid=s5414441;Pwd=s5414441;Charset=utf8"; //db 설정
		private string update_query;

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

				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.ExecuteNonQuery();

				conn.Close();
			}
		}

		public DataSet select_work_category(string query)
		{

			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = @"Select #query as 대분류 from work_category_list";
			update_query = update_query.Replace("#query", query);
			MySqlDataAdapter adapter = new MySqlDataAdapter(update_query, conn);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			return ds;
		}

		public DataSet select_work_category_where(string query, string where, string category, string As)
		{
			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = @"Select #query as #as from work_category_list where #where = '#category'";
			update_query = update_query.Replace("#query", query);
			update_query = update_query.Replace("#where", where);
			update_query = update_query.Replace("#category", category);
			update_query = update_query.Replace("#as", As);

			MySqlDataAdapter adapter = new MySqlDataAdapter(update_query, conn);
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

		public void revise(string query, DataTable table)
		{
			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = @"select #query from work_category_list";
			update_query = update_query.Replace("#query", query);
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			adapter.SelectCommand = new MySqlCommand(update_query, conn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

			adapter.UpdateCommand = builder.GetUpdateCommand();
			adapter.Update(table);
		}

		public DataSet select_work_category_re()
		{

			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = "select large_category as 대분류, medium_category as 중분류, small_category as 소분류 from work_category_list order by 대분류";
			MySqlDataAdapter adapter = new MySqlDataAdapter(update_query, conn);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			return ds;
		}

		public void Modify(DataTable table)
		{
			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = "select large_category as 대분류, medium_category as 중분류, small_category as 소분류 from work_category_list";
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			adapter.SelectCommand = new MySqlCommand(update_query, conn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

			adapter.UpdateCommand = builder.GetUpdateCommand();
			adapter.Update(table); 
		}
	}
}
