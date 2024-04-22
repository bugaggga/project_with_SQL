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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form ifrm = new Salespeople();
			ifrm.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form ifrm = new Customers();
			ifrm.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form ifrm = new Product();
			ifrm.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form ifrm = new ITOGI();
			ifrm.ShowDialog();
		}
	}
}
