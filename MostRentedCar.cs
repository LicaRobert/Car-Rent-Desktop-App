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
    public partial class MostRentedCar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=academy_net;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public MostRentedCar()
        {
            InitializeComponent();
        }

        private void MostRentedCar_Load(object sender, EventArgs e)
        {
             con.Open();

            //In this table we can see the most rented cars and the least rented cars.
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT CarModel, COUNT(CarModel) FROM CarRent GROUP BY CarModel Order BY Count(CarModel) DESC", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            MenuScreenForm menuScreen = new MenuScreenForm();
            menuScreen.Show();

            Close();
        }
    }
}
