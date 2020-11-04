using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectERP
{
	public partial class Form2 : Form
	{
		private string select_large = "";
		DataSet data_set;

		public Form2()
		{
			InitializeComponent();
			Form2_Load();
			//dataGridView_large_ct.Columns.Add("대분류", );
		}

		// 초기 대분류 load
		private void Form2_Load()
		{
			DataGridView r = new DataGridView();
			try
			{
				data_set = master.GetInstance().select_work_category("DISTINCT large_category");
				
				dataGridView_large_ct.DataSource = data_set.Tables[0];

			//	gridview_duplicate(dataGridView_large_ct);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void button_large_revise_Click(object sender, EventArgs e)
		{
			/*
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_large_ct.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

			string update_query = string.Empty;

			if (dtChanges != null)
			{
				for (int i = 0; i < dtChanges.Rows.Count; i++)
				{

					update_query = @"UPDATE work_category SET large_category = '#large_category' WHERE sid = '#sid'";
					update_query = update_query.Replace("#large_category", dtChanges.Rows[i]["large_category"].ToString());
					update_query = update_query.Replace("#sid", dtChanges.Rows[i]["sid"].ToString());

					int result = master.GetInstance().excute(update_query);

					if (result < 0) return;
				}
			}
			dtChanges = null;

			Form2_Load();

			this.Cursor = Cursors.Default;
			*/

			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_large_ct.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

			string update_query = string.Empty;
			if (dtChanges != null)
			{
				for (int i = 0; i < dtChanges.Rows.Count; i++)
				{

					update_query = @"UPDATE work_category SET large_category = '#large_category' WHERE large_category = ";
					update_query = update_query.Replace("#large_category", dtChanges.Rows[i]["large_category"].ToString());
					//update_query = update_query.Replace("#sid", dtChanges.Rows[i]["sid"].ToString());

					int result = master.GetInstance().excute(update_query);

					if (result < 0) return;
				}
			}
			dtChanges = null;

			Form2_Load();

			this.Cursor = Cursors.Default;
		}

		private void button_large_plus_Click(object sender, EventArgs e)
		{
			
		}

		private void button_large_del_Click(object sender, EventArgs e)
		{

		}

		private void button_medium_revise_Click(object sender, EventArgs e)
		{

		}

		private void button_medium_plus_Click(object sender, EventArgs e)
		{

		}

		private void button_medium_del_Click(object sender, EventArgs e)
		{

		}

		private void button_small_revise_Click(object sender, EventArgs e)
		{

		}

		private void button_small_plus_Click(object sender, EventArgs e)
		{

		}

		private void button_small_del_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView_large_ct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			select_large = this.dataGridView_large_ct.CurrentRow.Cells["large_category"].Value.ToString();

			data_set = master.GetInstance().select_work_category_where("medium_category", "large_category", select_large);

			dataGridView_medium_ct.DataSource = data_set.Tables[0];
		}

		private void dataGridView_medium_ct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			select_large = this.dataGridView_medium_ct.CurrentRow.Cells["medium_category"].Value.ToString();

			data_set = master.GetInstance().select_work_category_where("small_category", "medium_category", select_large);

			dataGridView_small_ct.DataSource = data_set.Tables[0];
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form2_Load();

		}

		public void gridview_duplicate(DataGridView gridView)
		{
			for (int currentRow = 0; currentRow < gridView.Rows.Count - 1; currentRow++)
			{
				DataGridViewRow rowToCompare = gridView.Rows[currentRow];
				for (int otherRow = currentRow + 1; otherRow < gridView.Rows.Count; otherRow++)
				{
					DataGridViewRow row = gridView.Rows[otherRow];
					bool duplicateRow = true;
					if ((rowToCompare.Cells[0].Value) != (row.Cells[0].Value))
					{
						duplicateRow = false;
					}
					else if (duplicateRow)
					{
						rowToCompare.Cells.Clear();
					}
				}
			}
		}
	}
}
