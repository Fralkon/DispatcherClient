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
    public partial class UserForm : Form
    {
        MySQL mySQL;
        string idUser = "";
        public UserForm(MySQL mySQL)
        {
            this.mySQL = mySQL;
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(TypeUser));
        }
        public UserForm(MySQL mySQL, string idUser, string login, string password, string fio, string type)
        {
            this.mySQL = mySQL;
            this.idUser = idUser;
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(TypeUser));
            textBox1.Text = login;
            textBox2.Text = password;
            textBox3.Text = fio;
            comboBox1.Text = type;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите логин.");
                return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите пароль.");
                return;
            }
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Введите ФИО.");
                return;
            }
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите тип пользователя.");
                return;
            }
            if (idUser == "")
            {
                mySQL.SendSQL("INSERT admin (login, pass, type, name) VALUES('" + textBox1.Text + "'," + textBox2.Text + ",'"+comboBox1.Text+"','" + textBox3.Text + "')");
            }
            else
            {
                mySQL.SendSQL("UPDATE admin SET login = '" + textBox1.Text + "' , pass = '" + textBox2.Text + "', type = '"+comboBox1.Text+"', name = '"+textBox3.Text+"' WHERE id = " + idUser);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
