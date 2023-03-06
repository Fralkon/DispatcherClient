using System.Data;

namespace DispatcherClient
{
    public partial class Dispatcher : Form
    {
        MySQL mySQL = new MySQL();
        string filterText = "";
        public Dispatcher()
        {
            Auth auth = new Auth(mySQL);
            while (true)
            {
                auth.ShowDialog();
                if (auth.DialogResult == DialogResult.OK)
                    break;
                else if (auth.DialogResult == DialogResult.Cancel)
                {
                    this.Close();
                    break;
                }
            }
            InitializeComponent();
            if (auth.User == TypeUser.admin)
                àäìèíêàToolStripMenuItem.Visible = true;
            else
                àäìèíêàToolStripMenuItem.Visible = false;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            UpDateTable();
        }
        private void UpDateTable()
        {
            string SQLData = "SELECT orders.id, users.name, users.number, orders.address, orders.delivery_time, " +
                "orders.price, orders.order_time, orders.status FROM orders, users WHERE orders.id_user = users.id";
            string filterStatus = "";
            foreach (ToolStripMenuItem item in ñòàòóñToolStripMenuItem1.DropDownItems) {
                if (item.Checked)
                    filterStatus += "'"+ item.Text + "',";
            }
            if (ñîçäàíîToolStripMenuItem1.Checked)
                filterStatus += "'Ñîçäàíî',";
            if (filterStatus != "")
                SQLData += " AND (status IN(" + filterStatus.Substring(0, filterStatus.Length - 1) + "))";
            if(filterText != "")
                SQLData += " AND (orders.id LIKE '%"+filterText+"%' OR users.name LIKE '%" + filterText + "%' OR users.number LIKE '%" + filterText+ "%' OR orders.address LIKE '%" + filterText+"%')";
            //MessageBox.Show(SQLData);
            DataTable datatable = mySQL.GetDataTableSQL(SQLData);
            datatable.Columns["id"].ColumnName = "Íîìåğ";
            datatable.Columns["name"].ColumnName = "ÔÈÎ";
            datatable.Columns["number"].ColumnName = "Òåëåôîí";
            datatable.Columns["address"].ColumnName = "Àäğåñ";
            datatable.Columns["delivery_time"].ColumnName = "Âğåìÿ äîñòàâêè";
            datatable.Columns["price"].ColumnName = "Ñóììà";
            datatable.Columns["order_time"].ColumnName = "Âğåìÿ çàÿâêè";
            datatable.Columns["status"].ColumnName = "Ñòàòóñ";
            dataGridView1.DataSource = datatable;
        }
        private void íîâàÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order(mySQL, Order.OrderType.NewOrder);
            order.ShowDialog();
            UpDateTable();
        }
        private void èçìåíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Order order = new Order(mySQL, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), Order.OrderType.ÑhangeOrder);
                order.ShowDialog();
                UpDateTable();
            }
            else
                MessageBox.Show("Âûáåğèòå çàÿâêó");
        }
        private void îòïğàâëåíîToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Âûáåğèòå çàÿâêó");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterText = searchText.Text;
            UpDateTable();
        }
        private void äóáëèğîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count != 0)
            {
                Order order = new Order(mySQL, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), Order.OrderType.DuplicateOrder);
                order.ShowDialog();
                UpDateTable();
            }
            else
                MessageBox.Show("Âûáåğèòå çàÿâêó");
        }
        private void ñîçäàíîToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            item.Checked = item.Checked == true ? false : true;
            UpDateTable();
        }

        private void òîâàğûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products productsForm = new Products();
            productsForm.ShowDialog();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ïîëüçîâàòåëèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admins adminsForm = new Admins();
            adminsForm.ShowDialog();
        }
    }
    public enum TypeUser
    {
        admin,
        dispatcher
    }
}