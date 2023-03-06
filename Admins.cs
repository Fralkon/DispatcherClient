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
    public partial class Admins : Form
    {
        MySQL mySql = new MySQL();
        public Admins()
        {
            InitializeComponent();
            UpDateTable();
        }
        public void UpDateTable()
        {
            using (DataTable table = mySql.GetDataTableSQL("SELECT * FROM admin"))
            {
                dataGridView1.DataSource = table;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(mySql);
            userForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                mySql.SendSQL("DELETE FROM admin WHERE id = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
                UserForm userForm = new UserForm(mySql, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                     dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                      dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                      dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                      dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                userForm.ShowDialog();
                UpDateTable();
            }
            else
            {
                MessageBox.Show("Выделите товар.");
            }
        }
    }
}
