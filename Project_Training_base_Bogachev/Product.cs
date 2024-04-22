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
	public partial class Product : Form
	{
		public Product()
		{
			InitializeComponent();
		}

		private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.training_base_BogachevDataSet);

        }

		private void Product_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "training_base_BogachevDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.training_base_BogachevDataSet.Product);

        }

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			button1.Enabled = true;
		}

		private System.Windows.Forms.DataGridViewColumn COL;
		private void button1_Click(object sender, EventArgs e)
		{
			COL = new System.Windows.Forms.DataGridViewColumn();

			switch (listBox1.SelectedIndex)
			{
				case 0:
					COL = dataGridViewTextBoxColumn2;
					break;
				case 1:
					COL = dataGridViewTextBoxColumn3;
					break;
			}

			if (radioButton1.Checked)
			{
				productDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
			}
			else
				productDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			productBindingSource.Filter = "PNAME='" + comboBox1.Text + "'";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			productBindingSource.Filter = "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < productDataGridView.ColumnCount - 1; i++)
			{
				for (int j = 0; j < productDataGridView.RowCount - 1; j++)
				{
					productDataGridView[i, j].Style.BackColor = Color.White;
					productDataGridView[i, j].Style.ForeColor = Color.Black;
				}
			}

			for (int i = 0; i < productDataGridView.ColumnCount - 1; i++)
			{
				for (int j = 0; j < productDataGridView.RowCount - 1; j++)
				{
					if (productDataGridView[i,j].Value.ToString().IndexOf(textBox1.Text) != -1)
					{
						productDataGridView[i, j].Style.BackColor = Color.AliceBlue;
						productDataGridView[i, j].Style.ForeColor = Color.Blue;
					}
					
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
