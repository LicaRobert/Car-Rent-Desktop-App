using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarDesktopApp
{
    public partial class ListCustomersForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=academy_net;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public ListCustomersForm()
        {
            InitializeComponent();

            dataGridView1.RowHeadersVisible = false;
        }

        private void ListCustomersForm_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Customers", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void GetBackMenuBtn_Click(object sender, EventArgs e)
        {
            MenuScreenForm form = new MenuScreenForm();
            form.Show();

            Close();
        }
    }
}
