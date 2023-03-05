using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispatcherClient
{
    public partial class ProductForm : Form
    {
        MySQL mySQL;
        string idProduct = "";
        public ProductForm(MySQL mySQL)
        {
            this.mySQL = mySQL;
            InitializeComponent();
        }
        public ProductForm(MySQL mySQL, string idProduct, string name, string price)
        {
            this.mySQL = mySQL;
            this.idProduct = idProduct;
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = price;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 )
            {
                MessageBox.Show("Введите наименование продукта.");
                return;
            }
            if(textBox2.Text.Length == 0 || !int.TryParse(textBox2.Text, out int price)) {
                MessageBox.Show("Введите правильно стоимость товара.");
                return;
            }
            if (idProduct == "")
            {
                mySQL.SendSQL("INSERT products (name, price) VALUES('" + textBox1.Text + "'," + price.ToString() + ")");
            }
            else
            {
                mySQL.SendSQL("UPDATE products SET name = '" + textBox1.Text + "' , price = " + price.ToString() + " WHERE id = " + idProduct);
            }
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
