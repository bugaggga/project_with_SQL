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
	public partial class ITOGI : Form
	{
		public ITOGI()
		{
			InitializeComponent();
		}

		private void ITOGI_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "training_base_BogachevDataSet.Sum_Orders". При необходимости она может быть перемещена или удалена.
            this.sum_OrdersTableAdapter.Fill(this.training_base_BogachevDataSet.Sum_Orders);

        }

		private void button1_Click(object sender, EventArgs e)
		{
			Form ifrm = new ITOGI_tv();
			ifrm.ShowDialog();
		}
	}
}
