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
    public partial class Auth : Form
    {
        MySQL mySQL;
        public Auth(MySQL mySQL)
        {
            this.mySQL = mySQL;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox2.Text.Length > 0)
                {
                    using (DataTable user = mySQL.GetDataTableSQL("SELECT * FROM admin WHERE login = '"+textBox1.Text+"'"))
                    {
                        if (user.Rows.Count > 0)
                        {
                            if (user.Rows[0]["pass"].ToString() == textBox2.Text)
                            {
                                if(user.Rows[0]["type"].ToString() == TypeUser.dispatcher.ToString())
                                {
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                            else
                                MessageBox.Show("Не верный пароль");
                        }
                        else
                            MessageBox.Show("Не верный логин");
                    }
                }
                else
                    MessageBox.Show("Не указан пароль");
            }
            else
                MessageBox.Show("Не указан логин");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
