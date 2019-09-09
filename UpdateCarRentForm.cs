using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarDesktopApp
{
    public partial class UpdateCarRentForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=academy_net;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public UpdateCarRentForm()
        {
            InitializeComponent();
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            MenuScreenForm form = new MenuScreenForm();
            form.Show();

            Close();
        }

        private void UpdateCarBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(startDateTextBox.Text.Trim());
            bool isValid2 = regex.IsMatch(startDateTextBox.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(startDateTextBox.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt);
            isValid2 = DateTime.TryParseExact(endDateTextBox.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt);

            DateTime startData = DateTime.Parse(startDateTextBox.Text);
            DateTime endData = DateTime.Parse(endDateTextBox.Text);

            if (!isValid || startDateTextBox.Text == "")
            {
                MessageBox.Show("Invalid start date.");
            }

            else if (!isValid2 || endDateTextBox.Text == "")
            {
                MessageBox.Show("Invalid end date.");
            }

            else if (cityTextBox.Text == "")
            {
                MessageBox.Show("Introduce a city.");
            }
            else if (startData > endData)
            {
                MessageBox.Show("The start data cannot be bigger or equal than the end data.");
            }

            else
            {
                con.Open();

                //if the car rent ID does not exist it will cannot update anything.

                SqlCommand command = con.CreateCommand();
                command.CommandText = "Select * from CarRent where CarRentID = '" + carRentIDTextBox.Text + "'";
                command.Parameters.AddWithValue("@CarRentID", carRentIDTextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);


                //if the model of the car does not exist in the Cars table it will give an error.
                //it will cannot update the model of the car.
                SqlCommand command2 = con.CreateCommand();
                command2.CommandText = "Select * from Customers where CostumerID = '" + ClientIDTextBox.Text + "'";
                command2.Parameters.AddWithValue("@CostumerID", ClientIDTextBox.Text);
                SqlDataAdapter sda2 = new SqlDataAdapter(command2);
                DataTable dataTable2 = new DataTable();
                sda2.Fill(dataTable2);


                //if the  client ID does not exist in the Customer table it will give an error.
                //it will cannot update the client ID.
                SqlCommand command3 = con.CreateCommand();
                command3.CommandText = "Select * from Cars where Model = '" + carModelTextBox.Text + "'";
                command3.Parameters.AddWithValue("@Model", carModelTextBox.Text);
                SqlDataAdapter sda3 = new SqlDataAdapter(command3);
                DataTable dataTable3 = new DataTable();
                sda3.Fill(dataTable3);


                //if the  location does not exist in the Customer table it will give an error.
                //it will cannot update the location.
                SqlCommand command4 = con.CreateCommand();
                command4.CommandText = "Select * from Cars where Model = '" + carModelTextBox.Text + "'";
                command4.Parameters.AddWithValue("@Model", carModelTextBox.Text);
                SqlDataAdapter sda4 = new SqlDataAdapter(command4);
                DataTable dataTable4 = new DataTable();
                sda4.Fill(dataTable4);

                if (dataTable.Rows.Count > 0 && dataTable2.Rows.Count > 0 && dataTable3.Rows.Count > 0 && dataTable4.Rows.Count > 0)
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = " UPDATE CarRent SET ClientID = '" + ClientIDTextBox.Text + "' , CarModel = '" + carModelTextBox.Text + "' , StartDate = '" + startDateTextBox.Text + "' , EndDate = '" + endDateTextBox.Text + "' , City = '" + cityTextBox.Text + "' Where CarRentID = '" + carRentIDTextBox.Text + "'";

                    cmd.ExecuteNonQuery();

                    Close();

                    con.Close();

                    MenuScreenForm form = new MenuScreenForm();
                    form.Show();
                }

                else
                {
                    MessageBox.Show("The car rent ID id does not exist or the model of the car or the client ID or the location it does not exists in our database to be updated.");
                }

            }
        }
    }
}
