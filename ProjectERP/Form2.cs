using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectERP
{
	public partial class Form2 : Form
	{
		DataSet data_set;

		public Form2()
		{
			InitializeComponent();
			Form2_Load();
		}

		// 초기 대분류 load
		private void Form2_Load()
		{
			try
			{
				data_set = master.GetInstance().select_work_category_re();

				dataGridView_master.DataSource = data_set.Tables[0];

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button_Refresh_Click(object sender, EventArgs e)
		{
			Form2_Load();
		}

		private void button_revise_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_master.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

			master.GetInstance().Modify(dtChanges);

			Form2_Load();

			this.Cursor = Cursors.Default;
		}

		private void button_plus_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_master.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Added);

			master.GetInstance().Modify(dtChanges);

			Form2_Load();

			this.Cursor = Cursors.Default;
		}

		private void dataGridView_master_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			if (MessageBox.Show("삭제하시겠습니까?","지정한 행삭제",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.No)
			{
				e.Cancel = true; //삭제 취소
			}
		}

		private void dataGridView_master_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			row_delete();
		}

		private void row_delete()
		{
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_master.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Deleted);

			master.GetInstance().Modify(dtChanges);

			Form2_Load();

			this.Cursor = Cursors.Default;
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_master.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Deleted);

			master.GetInstance().Modify(dtChanges);

			Form2_Load();

			this.Cursor = Cursors.Default;
		}
	}
}
