using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarDesktopApp
{
    public partial class MenuScreenForm : Form
    {
        public MenuScreenForm()
        {
            InitializeComponent();
        }

        private void MenuScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D1)
            {
                RegisterNewCarRentForm form = new RegisterNewCarRentForm();
                form.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D2)
            {
                UpdateCarRentForm form = new UpdateCarRentForm();
                form.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D3)
            {
                ListRentsForm form = new ListRentsForm();
                form.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D4)
            {
                ListAvailableCarsForm form = new ListAvailableCarsForm();
                form.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D5)
            {
                RegisterNewCustomerForm form = new RegisterNewCustomerForm();
                form.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D6)
            {
                UpdateCustomerForm form = new UpdateCustomerForm();
                form.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D7)
            {
                ListCustomersForm form = new ListCustomersForm();
                form.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D8)
            {
                MostRentedCar rentedCar = new MostRentedCar();
                rentedCar.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D9)
            {
                CustomersNrOfRentsForm customerNrRents = new CustomersNrOfRentsForm();
                customerNrRents.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D0)
            {
                Application.Exit();
            }

            else
            {
                MessageBox.Show("This is not a valid option.");
            }
        }
    }
}
