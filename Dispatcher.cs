namespace DispatcherClient
{
    public partial class Dispatcher : Form
    {
        MySQL mySQL = new MySQL();
        public Dispatcher()
        {
            while (true)
            {
                Auth auth = new Auth(mySQL);
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
            UpDateTable();
        }
        private void UpDateTable()
        {
            dataGridView1.DataSource = mySQL.GetDataTableSQL("SELECT * FROM orders");
        }
        private void ÌÓ‚‡ˇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order(mySQL);
            order.ShowDialog();
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