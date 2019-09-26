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
    public partial class UpdateCustomerForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=academy_net;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        DataSet ds = new DataSet();
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void UpdateCustomerBtn_MouseClick(object sender, MouseEventArgs e)
        {

            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(birthDateTextBox.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(birthDateTextBox.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt);

            con.Open();

            if (!isValid || birthDateTextBox.Text == "")
            {
                MessageBox.Show("Invalid birth date.");
            }

            else if (clientNameTextBox.Text == "")
            {
                MessageBox.Show("Introduce a client name.");
            }

            else if (locationTextBox.Text == "")
            {
                MessageBox.Show("Introduce a location.");
            }

            else if (ZIPCodeTextBox.Text.Length < 6)
            {
                MessageBox.Show("The ZIP Code cannot be lower than 6 characters.");
            }

            else if (clientIDTextBox.Text == "")
            {
                MessageBox.Show("Introduce an ID to know what customer you want to update.");
            }


            else
            {

                SqlCommand cmd2;
                cmd2 = new SqlCommand("Select * FROM Customers WHERE CostumerID = '" + clientIDTextBox.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;

                if (i > 0)
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = " UPDATE Customers SET Name = '" + clientNameTextBox.Text + "' , BirthDate = '" + birthDateTextBox.Text + "' , Location = '" + locationTextBox.Text + "' Where CostumerID = '" + clientIDTextBox.Text + "'";

                    cmd.ExecuteNonQuery();

                    Close();

                    MenuScreenForm form = new MenuScreenForm();
                    form.Show();
                }

                //if the the customer ID introduced does not exists to update,there will be an error message.

                else
                {
                    MessageBox.Show("The customer inserted with this ID " + clientIDTextBox.Text + " does not exists.");
                    ds.Clear();
                }
            }
            con.Close();
        }
        private void ZIPCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            ZIPCodeTextBox.MaxLength = 6;
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            MenuScreenForm form = new MenuScreenForm();
            form.Show();

            Close();
        }
    }
}
