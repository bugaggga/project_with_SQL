using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Training_base_Bogachev
{
	public partial class ITOGI_tv : Form
	{
		public ITOGI_tv()
		{
			InitializeComponent();
		}

		private void ITOGI_tv_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "training_base_BogachevDataSet.Max_Sum_order". При необходимости она может быть перемещена или удалена.

			// TODO: данная строка кода позволяет загрузить данные в таблицу "training_base_BogachevDataSet.Max_Sum_orders". При необходимости она может быть перемещена или удалена.
			//this.max_Sum_ordersTableAdapter.Fill(this.training_base_BogachevDataSet.Max_Sum_orders);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "training_base_BogachevDataSet.Sum_Orders". При необходимости она может быть перемещена или удалена.
			this.sum_OrdersTableAdapter.Fill(this.training_base_BogachevDataSet.Sum_Orders);

        }

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = Convert.ToString(14985);
		}
	}
}
