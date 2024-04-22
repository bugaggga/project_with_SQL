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
	public partial class Salespeople : Form
	{
		public Salespeople()
		{
			InitializeComponent();
		}

		private void salespeopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.salespeopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.training_base_BogachevDataSet);

        }

		private void Salespeople_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "training_base_BogachevDataSet.Salespeople". При необходимости она может быть перемещена или удалена.
            this.salespeopleTableAdapter.Fill(this.training_base_BogachevDataSet.Salespeople);

        }
    }
}
