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
    public partial class Products : Form
    {
        MySQL mySql = new MySQL();
        public Products()
        {
            InitializeComponent();
            UpDateTable();
        }
        public void UpDateTable()
        {
            using (DataTable table = mySql.GetDataTableSQL("SELECT * FROM products"))
            {
                dataGridView1.DataSource= table;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(mySql);
            productForm.ShowDialog();
            UpDateTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                mySql.SendSQL("DELETE FROM products WHERE id = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                UpDateTable();
            }
            else
            {
                MessageBox.Show("Выделите товар.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ProductForm productForm = new ProductForm(mySql, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                     dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                      dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                productForm.ShowDialog();
                UpDateTable();
            }
            else
            {
                MessageBox.Show("Выделите товар.");
            }
        }
    }
}
