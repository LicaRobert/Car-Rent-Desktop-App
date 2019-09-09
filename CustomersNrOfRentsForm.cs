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
    public partial class CustomersNrOfRentsForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=academy_net;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public CustomersNrOfRentsForm()
        {
            InitializeComponent();
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            MenuScreenForm menuScreen = new MenuScreenForm();
            menuScreen.Show();

            Close();
        }

        private void CustomersNrOfRentsForm_Load(object sender, EventArgs e)
        {
            con.Open();

            //In this table we can see the customers ID with the most rents.
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ClientID, COUNT(ClientID) FROM CarRent GROUP BY ClientID Order BY Count(ClientID) DESC", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
