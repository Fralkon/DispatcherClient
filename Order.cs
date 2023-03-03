using System.Data;
namespace DispatcherClient
{
    public partial class Order : Form
    {
        public enum OrderType { 
            NewOrder,
            DuplicateOrder,
            СhangeOrder
        }
        MySQL mySQL;
        List<Product> productList = new List<Product>();
        string idOrder = "";
        OrderType orderType;
        public Order(MySQL mySQL, OrderType orderType)
        {
            this.orderType = orderType;
            this.mySQL = mySQL;
            InitializeComponent();
            basketGrid.Columns.Add("name", "Продукт");
            basketGrid.Columns.Add("count", "Количество");
            basketGrid.Columns.Add("price","Цена");
            using (DataTable dataTable = mySQL.GetDataTableSQL("SELECT * FROM products"))
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    productList.Add(new Product(dr));
                    products.Items.Add(dr["name"].ToString());
                }
            }
        }
        public Order(MySQL mySQL, string idOrder, OrderType orderType)
        {
            this.orderType = orderType;
            this.idOrder = idOrder;
            this.mySQL = mySQL;
            InitializeComponent(); 
            using (DataTable dataTable = mySQL.GetDataTableSQL("SELECT * FROM products"))
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    productList.Add(new Product(dr));
                    products.Items.Add(dr["name"].ToString());
                }
            }
            using (DataTable dataTable = mySQL.GetDataTableSQL("SELECT * FROM orders, users WHERE orders.id = " + idOrder + " AND orders.id_user = users.id")) 
            {
                if(dataTable.Rows.Count == 1)
                {
                    idOrder = dataTable.Rows[0]["id"].ToString();
                    fio.Text = dataTable.Rows[0]["name"].ToString();
                    addr.Text = dataTable.Rows[0]["address"].ToString();
                    tell.Text = dataTable.Rows[0]["number"].ToString();
                    dateTimePicker1.Value = DateTime.Parse(dataTable.Rows[0]["delivery_time"].ToString());
                }
            }
            basketGrid.Columns.Add("name", "Продукт");
            basketGrid.Columns.Add("count", "Количество");
            basketGrid.Columns.Add("price", "Цена");
            using (DataTable dataProducts = mySQL.GetDataTableSQL("SELECT products.name, order_items.count, products.price FROM order_items, products WHERE id_order = " + idOrder +
                " AND order_items.id_product = products.id"))
            {
                if(dataProducts.Rows.Count > 0)
                {
                    foreach (DataRow row in dataProducts.Rows)
                    {
                        int newRow = basketGrid.Rows.Add();
                        basketGrid.Rows[newRow].Cells[0].Value = row["name"].ToString();
                        basketGrid.Rows[newRow].Cells[1].Value = row["count"].ToString();
                        basketGrid.Rows[newRow].Cells[2].Value = (int.Parse(row["count"].ToString()) * int.Parse(row["price"].ToString()));
                    }
                }
            }
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (products.Text.Length == 0)
            {
                MessageBox.Show("Выберите товар");
                return;
            }
            if (count.Text.Length == 0 || !int.TryParse(count.Text, out int countProduct))
            {
                MessageBox.Show("Введите количество товара");
                return;
            }
            if(countProduct <= 0)
            {
                MessageBox.Show("Количество товара не может быть менее 1 еденицы");
                return;
            }
            int rowNumber = basketGrid.Rows.Add();
            basketGrid.Rows[rowNumber].Cells["name"].Value = products.Text;
            basketGrid.Rows[rowNumber].Cells["count"].Value = countProduct;
            foreach (Product pr in productList)
            {
                if (pr.Name == products.Text)
                {
                    basketGrid.Rows[rowNumber].Cells["price"].Value = pr.Price * countProduct;
                    break;
                }
            }
            int summ = 0;
            foreach(DataGridViewRow row in basketGrid.Rows)
                summ += (int)row.Cells["price"].Value;
            allPrice.Text = summ.ToString();
            priceCountPR.Text = "0";
            PricePR.Text = "0";
            products.SelectedIndex = -1;
            count.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(fio.Text.Length == 0)
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            if (addr.Text.Length == 0)
            {
                MessageBox.Show("Введите адресс");
                return;
            }
            if (tell.Text.Length == 0)
            {
                MessageBox.Show("Введите телефон");
                return;
            }
            if (basketGrid.RowCount == 0)
            {
                MessageBox.Show("Добавите товар");
                return;
            }
            if (orderType == OrderType.NewOrder)
            {
                string userID = GetUserID(fio.Text, tell.Text);
                int summ = 0;
                foreach (DataGridViewRow row in basketGrid.Rows)
                    summ += (int)row.Cells["price"].Value;
                string numberOrder = mySQL.InsertSQL("INSERT orders (id_user, order_time, delivery_time, address, price, status) " +
                    "VALUES('" + userID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' , '" + addr.Text + "'," + summ.ToString() + ",'Создано')").ToString();
                foreach (DataGridViewRow row in basketGrid.Rows)
                {
                    int prodID = GetProductID(row.Cells["name"].Value.ToString());
                    if (prodID == -1)
                        continue;
                    mySQL.SendSQL("INSERT order_items (id_order, id_product, count) VALUES(" + numberOrder + "," + prodID.ToString() + "," + row.Cells["count"].Value.ToString() + ")");
                }
                MessageBox.Show("Заявка добавлена в систему");
            }
            else if(orderType == OrderType.СhangeOrder)
            {
                int summ = 0;
                foreach (DataGridViewRow row in basketGrid.Rows)
                    summ += (int)row.Cells["price"].Value;
                mySQL.SendSQL("UPDATE orders SET delivery_time = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    "address = '" + addr.Text + "', price = '" + summ.ToString() + "' WHERE id = " + idOrder);
                mySQL.SendSQL("DELETE FROM order_items WHERE id_order = " + idOrder);
                foreach (DataGridViewRow row in basketGrid.Rows)
                {
                    int prodID = GetProductID(row.Cells["name"].Value.ToString());
                    if (prodID == -1)
                        continue;
                    mySQL.SendSQL("INSERT order_items (id_order, id_product, count) VALUES(" + idOrder + "," + prodID.ToString() + "," + row.Cells["count"].Value.ToString() + ")");

                }
            }
            else if (orderType == OrderType.DuplicateOrder)
            {
                string userID = GetUserID(fio.Text, tell.Text);
                int summ = 0;
                foreach (DataGridViewRow row in basketGrid.Rows)
                    summ += (int)row.Cells["price"].Value;
                string numberOrder = mySQL.InsertSQL("INSERT orders (id_user, order_time, delivery_time, address, price, status) " +
                    "VALUES('" + userID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' , '" + addr.Text + "'," + summ.ToString() + ",'Создано')").ToString();
                foreach (DataGridViewRow row in basketGrid.Rows)
                {
                    int prodID = GetProductID(row.Cells["name"].Value.ToString());
                    if (prodID == -1)
                        continue;
                    mySQL.SendSQL("INSERT order_items (id_order, id_product, count) VALUES(" + numberOrder + "," + prodID.ToString() + "," + row.Cells["count"].Value.ToString() + ")");
                }
                MessageBox.Show("Заявка добавлена в систему");
            }
            this.Close();
        }
        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Product pr in productList)
            {
                if (pr.Name == products.Text)
                {
                    PricePR.Text =  pr.Price.ToString();
                    break;
                }
            }
        }
        private void count_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(count.Text, out int countProduct))
            {
                if(products.Text.Length!= 0)
                {
                    foreach (Product pr in productList)
                    {
                        if (pr.Name == products.Text)
                        {
                            priceCountPR.Text = (countProduct*pr.Price).ToString();
                            break;
                        }
                    }
                }
            }
        }
        private void basketGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int summ = 0;
            foreach (DataGridViewRow row in basketGrid.Rows)
                summ += (int)row.Cells["price"].Value;
            allPrice.Text = summ.ToString();
        }
        private string GetUserID(string name, string number)
        {
            using (DataTable userFind = mySQL.GetDataTableSQL("SELECT id FROM users WHERE name = '"+name+ "' OR number = '"+number+"'"))
            {
                if (userFind.Rows.Count == 0)
                    return mySQL.InsertSQL("INSERT users (name, number) VALUES('" + name + "','" + number + "')").ToString();
                else
                    return userFind.Rows[0]["id"].ToString();
            }
        }
        private int GetProductID(string name)
        {
            foreach(var prod in productList)
            {
                if(name == prod.Name)
                    return prod.ID;
            }
            return -1;
        }
    }
    class Product
    {
        public Product() { }
        public Product(int ID, string name, int price)
        {
            this.ID = ID;
            this.Name = name;
            this.Price = price;
        }
        public Product(DataRow dataRow)
        {
            ID = int.Parse(dataRow["id"].ToString());
            Name = dataRow["name"].ToString();
            Price = int.Parse(dataRow["price"].ToString());
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ID { get; set; }
    }
}
