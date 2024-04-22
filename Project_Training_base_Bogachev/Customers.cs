using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Training_base_Bogachev
{
	public partial class Customers : Form
	{
		public Customers()
		{
			InitializeComponent();
		}

		private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.training_base_BogachevDataSet);

        }

		private void Customers_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "training_base_BogachevDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.training_base_BogachevDataSet.Customers);

        }

		private void SaveButton_Click(object sender, EventArgs e)
		{
			customersTableAdapter.Update(training_base_BogachevDataSet);
		}

		private void customersDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}
	}
}
