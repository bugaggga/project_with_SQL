namespace Project_Training_base_Bogachev
{
	partial class ITOGI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITOGI));
			System.Windows.Forms.Label oNUMLabel;
			System.Windows.Forms.Label сУММА_ЗАКАЗАLabel;
			System.Windows.Forms.Label oDATELabel;
			this.training_base_BogachevDataSet = new Project_Training_base_Bogachev.Training_base_BogachevDataSet();
			this.sum_OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sum_OrdersTableAdapter = new Project_Training_base_Bogachev.Training_base_BogachevDataSetTableAdapters.Sum_OrdersTableAdapter();
			this.tableAdapterManager = new Project_Training_base_Bogachev.Training_base_BogachevDataSetTableAdapters.TableAdapterManager();
			this.sum_OrdersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.sum_OrdersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.oNUMTextBox = new System.Windows.Forms.TextBox();
			this.сУММА_ЗАКАЗАTextBox = new System.Windows.Forms.TextBox();
			this.oDATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			oNUMLabel = new System.Windows.Forms.Label();
			сУММА_ЗАКАЗАLabel = new System.Windows.Forms.Label();
			oDATELabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.training_base_BogachevDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sum_OrdersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sum_OrdersBindingNavigator)).BeginInit();
			this.sum_OrdersBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// training_base_BogachevDataSet
			// 
			this.training_base_BogachevDataSet.DataSetName = "Training_base_BogachevDataSet";
			this.training_base_BogachevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sum_OrdersBindingSource
			// 
			this.sum_OrdersBindingSource.DataMember = "Sum_Orders";
			this.sum_OrdersBindingSource.DataSource = this.training_base_BogachevDataSet;
			// 
			// sum_OrdersTableAdapter
			// 
			this.sum_OrdersTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.Customers_1TableAdapter = null;
			this.tableAdapterManager.CustomersTableAdapter = null;
			this.tableAdapterManager.Order_DetailsTableAdapter = null;
			this.tableAdapterManager.Orders_1TableAdapter = null;
			this.tableAdapterManager.OrdersTableAdapter = null;
			this.tableAdapterManager.Product_arhivTableAdapter = null;
			this.tableAdapterManager.ProductTableAdapter = null;
			this.tableAdapterManager.Salespeople_1TableAdapter = null;
			this.tableAdapterManager.SalespeopleTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Project_Training_base_Bogachev.Training_base_BogachevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// sum_OrdersBindingNavigator
			// 
			this.sum_OrdersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.sum_OrdersBindingNavigator.BindingSource = this.sum_OrdersBindingSource;
			this.sum_OrdersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.sum_OrdersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.sum_OrdersBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.sum_OrdersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sum_OrdersBindingNavigatorSaveItem});
			this.sum_OrdersBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.sum_OrdersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.sum_OrdersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.sum_OrdersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.sum_OrdersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.sum_OrdersBindingNavigator.Name = "sum_OrdersBindingNavigator";
			this.sum_OrdersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.sum_OrdersBindingNavigator.Size = new System.Drawing.Size(800, 33);
			this.sum_OrdersBindingNavigator.TabIndex = 0;
			this.sum_OrdersBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 25);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// sum_OrdersBindingNavigatorSaveItem
			// 
			this.sum_OrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.sum_OrdersBindingNavigatorSaveItem.Enabled = false;
			this.sum_OrdersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sum_OrdersBindingNavigatorSaveItem.Image")));
			this.sum_OrdersBindingNavigatorSaveItem.Name = "sum_OrdersBindingNavigatorSaveItem";
			this.sum_OrdersBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
			this.sum_OrdersBindingNavigatorSaveItem.Text = "Сохранить данные";
			// 
			// oNUMLabel
			// 
			oNUMLabel.AutoSize = true;
			oNUMLabel.Location = new System.Drawing.Point(206, 201);
			oNUMLabel.Name = "oNUMLabel";
			oNUMLabel.Size = new System.Drawing.Size(61, 20);
			oNUMLabel.TabIndex = 1;
			oNUMLabel.Text = "ONUM:";
			// 
			// oNUMTextBox
			// 
			this.oNUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sum_OrdersBindingSource, "ONUM", true));
			this.oNUMTextBox.Location = new System.Drawing.Point(387, 198);
			this.oNUMTextBox.Name = "oNUMTextBox";
			this.oNUMTextBox.Size = new System.Drawing.Size(200, 26);
			this.oNUMTextBox.TabIndex = 2;
			// 
			// сУММА_ЗАКАЗАLabel
			// 
			сУММА_ЗАКАЗАLabel.AutoSize = true;
			сУММА_ЗАКАЗАLabel.Location = new System.Drawing.Point(127, 256);
			сУММА_ЗАКАЗАLabel.Name = "сУММА_ЗАКАЗАLabel";
			сУММА_ЗАКАЗАLabel.Size = new System.Drawing.Size(140, 20);
			сУММА_ЗАКАЗАLabel.TabIndex = 3;
			сУММА_ЗАКАЗАLabel.Text = "СУММА ЗАКАЗА:";
			// 
			// сУММА_ЗАКАЗАTextBox
			// 
			this.сУММА_ЗАКАЗАTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sum_OrdersBindingSource, "СУММА ЗАКАЗА", true));
			this.сУММА_ЗАКАЗАTextBox.Location = new System.Drawing.Point(387, 253);
			this.сУММА_ЗАКАЗАTextBox.Name = "сУММА_ЗАКАЗАTextBox";
			this.сУММА_ЗАКАЗАTextBox.Size = new System.Drawing.Size(200, 26);
			this.сУММА_ЗАКАЗАTextBox.TabIndex = 4;
			// 
			// oDATELabel
			// 
			oDATELabel.AutoSize = true;
			oDATELabel.Location = new System.Drawing.Point(199, 142);
			oDATELabel.Name = "oDATELabel";
			oDATELabel.Size = new System.Drawing.Size(68, 20);
			oDATELabel.TabIndex = 5;
			oDATELabel.Text = "ODATE:";
			// 
			// oDATEDateTimePicker
			// 
			this.oDATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sum_OrdersBindingSource, "ODATE", true));
			this.oDATEDateTimePicker.Location = new System.Drawing.Point(387, 137);
			this.oDATEDateTimePicker.Name = "oDATEDateTimePicker";
			this.oDATEDateTimePicker.Size = new System.Drawing.Size(200, 26);
			this.oDATEDateTimePicker.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(257, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 37);
			this.label1.TabIndex = 7;
			this.label1.Text = "Итоги по заказам";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button1.Location = new System.Drawing.Point(286, 354);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(193, 38);
			this.button1.TabIndex = 8;
			this.button1.Text = "Табличный вид";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ITOGI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(oDATELabel);
			this.Controls.Add(this.oDATEDateTimePicker);
			this.Controls.Add(сУММА_ЗАКАЗАLabel);
			this.Controls.Add(this.сУММА_ЗАКАЗАTextBox);
			this.Controls.Add(oNUMLabel);
			this.Controls.Add(this.oNUMTextBox);
			this.Controls.Add(this.sum_OrdersBindingNavigator);
			this.Name = "ITOGI";
			this.Text = "ITOGI";
			this.Load += new System.EventHandler(this.ITOGI_Load);
			((System.ComponentModel.ISupportInitialize)(this.training_base_BogachevDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sum_OrdersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sum_OrdersBindingNavigator)).EndInit();
			this.sum_OrdersBindingNavigator.ResumeLayout(false);
			this.sum_OrdersBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Training_base_BogachevDataSet training_base_BogachevDataSet;
		private System.Windows.Forms.BindingSource sum_OrdersBindingSource;
		private Training_base_BogachevDataSetTableAdapters.Sum_OrdersTableAdapter sum_OrdersTableAdapter;
		private Training_base_BogachevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator sum_OrdersBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton sum_OrdersBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox oNUMTextBox;
		private System.Windows.Forms.TextBox сУММА_ЗАКАЗАTextBox;
		private System.Windows.Forms.DateTimePicker oDATEDateTimePicker;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}