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
    public partial class RegisterNewCustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=academy_net;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        DataSet ds = new DataSet();
        public RegisterNewCustomerForm()
        {
            InitializeComponent();
        }

        private void RegisterCustomerBtn_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(birthDateTextBox.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(birthDateTextBox.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), System.Globalization.DateTimeStyles.None, out dt);


            if (!isValid || birthDateTextBox.Text == "")
            {
                MessageBox.Show("Invalid birth date.");
                MenuScreenForm form = new MenuScreenForm();
                form.Show();
            }

            else if(clientNameTextBox.Text == "")
            {
                MessageBox.Show("Introduce a client name.");
                MenuScreenForm form = new MenuScreenForm();
                form.Show();
            }

            else if (locationTextBox.Text == "")
            {
                MessageBox.Show("Introduce a location.");
                MenuScreenForm form = new MenuScreenForm();
                form.Show();
            }

            else if (ZIPCodeTextBox.Text.Length < 6)
            {
                MessageBox.Show("The ZIP Code cannot be lower than 6 characters.");
                MenuScreenForm form = new MenuScreenForm();
                form.Show();
            }


            /* All the way up I have validated the fields.
            I cannot validate the Customer ID because it is a primary key on the field and  also
            it has auto increment.
            */

            else
            {
                con.Open();

                SqlCommand cmd2;
                cmd2 = new SqlCommand("Select * FROM Customers WHERE Name = '" + clientNameTextBox.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;

                //if the the customer introduced already exists,there will be an error message.

                if (i > 0)
                {
                    MessageBox.Show("The customer inserted with this name " + clientNameTextBox.Text + " already exists.");
                    ds.Clear();
                }
                else
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Customers values('" + clientNameTextBox.Text + "' , '" +
                                             birthDateTextBox.Text + "' , '" + locationTextBox.Text + "')";

                    cmd.ExecuteNonQuery();

                    Close();

                    con.Close();

                    MenuScreenForm form = new MenuScreenForm();
                    form.Show();
                }
            }
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

