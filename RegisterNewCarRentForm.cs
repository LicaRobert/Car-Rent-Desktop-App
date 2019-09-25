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
    public partial class RegisterNewCarRentForm : Form
    {
        // IT WILL BE INSERTED IN THE CAR RENT TABLE.

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=academy_net;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
 
        public RegisterNewCarRentForm()
        {
            InitializeComponent();
        }

        private void InsertCarBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(startDateTextBox.Text.Trim());
            bool isValid2 = regex.IsMatch(startDateTextBox.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(startDateTextBox.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt);
            isValid2 = DateTime.TryParseExact(endDateTextBox.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt);

            DateTime startData = DateTime.Parse(startDateTextBox.Text);
            DateTime endData = DateTime.Parse(endDateTextBox.Text);

            if (!isValid || startDateTextBox.Text == "" || !isValid2 || endDateTextBox.Text == "")
            {
                MessageBox.Show("Invalid date.");
                MenuScreenForm form = new MenuScreenForm();
                form.Show();
            }

            else if (cityTextBox.Text == "")
            {
                MessageBox.Show("Introduce a city.");
                MenuScreenForm form = new MenuScreenForm();
                form.Show();
            }
            else if(startData > endData)
            {
                MessageBox.Show("The start data cannot be bigger or equal than the end data.");
                MenuScreenForm form = new MenuScreenForm();
                form.Show();
            }

            else 
            {
                con.Open();

                //if the model of the car does not exist in the Cars table it will give an error.
                SqlCommand command = con.CreateCommand();
                command.CommandText = "Select * from Cars where Model = '" + carModelTextBox.Text + "'";
                command.Parameters.AddWithValue("@CarModel", carModelTextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                //if the  client ID does not exist in the Customer table it will give an error.
                SqlCommand command2 = con.CreateCommand();
                command2.CommandText = "Select * from Customers where CostumerID = '" + clientIDTextBox.Text + "'";
                command2.Parameters.AddWithValue("@CostumerID", clientIDTextBox.Text);
                SqlDataAdapter sda2 = new SqlDataAdapter(command2);
                DataTable dataTable2 = new DataTable();
                sda2.Fill(dataTable2);

                //if the  location does not exist in the Customer table it will give an error.
                SqlCommand command3 = con.CreateCommand();
                command3.CommandText = "Select * from Customers where Location = '" + cityTextBox.Text + "'";
                command3.Parameters.AddWithValue("@CostumerID", clientIDTextBox.Text);
                SqlDataAdapter sda3 = new SqlDataAdapter(command3);
                DataTable dataTable3 = new DataTable();
                sda3.Fill(dataTable3);


                if (dataTable.Rows.Count > 0 && dataTable2.Rows.Count > 0 & dataTable3.Rows.Count > 0)
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into CarRent values('" + clientIDTextBox.Text + "' , '" +
                    carModelTextBox.Text + "' , '" + startDateTextBox.Text + "' , '" + endDateTextBox.Text + "', '" + cityTextBox.Text + "')";

                    cmd.ExecuteNonQuery();

                    Close();

                    con.Close();


                    MenuScreenForm form = new MenuScreenForm();
                    form.Show();
                }

                else
                {
                    MessageBox.Show("The model of the car or the client ID or the location it does not exists in our database.Please check again.");
                }
            }
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            MenuScreenForm form = new MenuScreenForm();
            form.Show();

            Close();
        }

        private void ClientIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
