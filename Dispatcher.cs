using System.Data;

namespace DispatcherClient
{
    public partial class Dispatcher : Form
    {
        MySQL mySQL = new MySQL();
        string filterText = "";
        public Dispatcher()
        {
            //while (true)
            //{
            //    Auth auth = new Auth(mySQL);
            //    auth.ShowDialog();
            //    if (auth.DialogResult == DialogResult.OK)
            //        break;
            //    else if (auth.DialogResult == DialogResult.Cancel)
            //    {
            //        this.Close();
            //        break;
            //    }
            //}
            InitializeComponent();
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            UpDateTable();
        }
        private void UpDateTable()
        {
            string SQLData = "SELECT orders.id, users.name, users.number, orders.address, orders.delivery_time, " +
                "orders.price, orders.order_time, orders.status FROM orders, users WHERE orders.id_user = users.id";
            string filterStatus = " AND (status IN(";
            
            if (созданоToolStripMenuItem1.Checked)
                filterStatus += "'Создано',";
            if (filterStatus != " AND (status IN(")
                SQLData += filterStatus.Substring(0, filterStatus.Length - 1) + "))";
            if(filterText != "")
                SQLData += " AND (orders.id LIKE '%"+filterText+"%' OR users.name LIKE '%" + filterText + "%' OR users.number LIKE '%" + filterText+ "%' OR orders.address LIKE '%" + filterText+"%')";
            //MessageBox.Show(SQLData);
            DataTable datatable = mySQL.GetDataTableSQL(SQLData);
            datatable.Columns["id"].ColumnName = "Номер";
            datatable.Columns["name"].ColumnName = "ФИО";
            datatable.Columns["number"].ColumnName = "Телефон";
            datatable.Columns["address"].ColumnName = "Адрес";
            datatable.Columns["delivery_time"].ColumnName = "Время доставки";
            datatable.Columns["price"].ColumnName = "Сумма";
            datatable.Columns["order_time"].ColumnName = "Время заявки";
            datatable.Columns["status"].ColumnName = "Статус";
            dataGridView1.DataSource = datatable;
        }
        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order(mySQL, Order.OrderType.NewOrder);
            order.ShowDialog();
            UpDateTable();
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Order order = new Order(mySQL, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), Order.OrderType.СhangeOrder);
                order.ShowDialog();
                UpDateTable();
            }
            else
                MessageBox.Show("Выберите заявку");
        }
        private void отправленоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ToolStripMenuItem? item = sender as ToolStripMenuItem;
                MessageBox.Show(item.Text);
                if (item != null)
                {
                    mySQL.SendSQL("UPDATE orders SET status = '" + item.Text +"' WHERE id = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                UpDateTable();
            }
            else
                MessageBox.Show("Выберите заявку");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterText = searchText.Text;
            UpDateTable();
        }
        private void дублироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count != 0)
            {
                Order order = new Order(mySQL, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), Order.OrderType.DuplicateOrder);
                order.ShowDialog();
                UpDateTable();
            }
            else
                MessageBox.Show("Выберите заявку");
        }
        private void созданоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            item.Checked = item.Checked == true ? false : true;
            UpDateTable();
        }
    }
    enum TypeUser
    {
        admin,
        dispatcher,
        user
    }
}