using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Copy
{
    public partial class AddInvoice : UserControl
    {
        public Invoices InvoicesManager { get; set; }
        public AddInvoice()
        {
            InitializeComponent();
            customerTypeCombobox.SelectedItem = "Household customer";
            string currentMonth = DateTime.Now.Month.ToString();
            currentMonthCombobox.SelectedItem = currentMonth;
            numberOfPeopleInput.Text = "0";
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void customerTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            if (customerType == "Household customer")
                numberOfPeopleInput.Enabled = true;
            else
                numberOfPeopleInput.Enabled = false;
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void VATLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string message = "";
            bool isValid = true;
            if (customerCodeInput.Text == "")
            {
                isValid = false;
                message = "Please enter customer code!\n";
            }
            if (customerNameInput.Text == "")
            {
                isValid = false;
                message = "Please enter customer name!\n";
            }
            if (!customerNameInput.Text.All(char.IsLetter))
            {
                isValid = false;
                message = "Please enter customer name again!\n";
            }
            if (thisMonthNumberInput.Text == "")
            {
                isValid = false;
                message = "Please enter this month number!\n";
            }
            if (!thisMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                message = "Please enter this month number again!\n";
            }
            if (lastMonthNumberInput.Text == "")
            {
                isValid = false;
                message = "Please enter last month number!\n";
            }
            if (!lastMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                message = "Please enter last month number again!\n";
            }
            if (numberOfPeopleInput.Text == "")
            {
                isValid = false;
                message = "Please enter number of people!\n";
            }
            if (int.Parse(numberOfPeopleInput.Text) <= 0)
            {
                isValid = false;
                message = "Please enter number of people again!\n";
            }
            if (!numberOfPeopleInput.Text.All(char.IsDigit))
            {
                isValid = false;
                message = "Please enter number of people again!\n";
            }
            if (isValid == false)
            {
                MessageBox.Show(message);
                return;
            }
            string customerCode = customerCodeInput.Text;
            string customerName = customerNameInput.Text;
            string customerType = customerTypeCombobox.SelectedItem.ToString();
            int numberOfPeople = Convert.ToInt32(numberOfPeopleInput.Text);
            int lastMonthNumber = Convert.ToInt32(lastMonthNumberInput.Text);
            int thisMonthNumber = Convert.ToInt32(thisMonthNumberInput.Text);
            int currentMonth = Convert.ToInt32(currentMonthCombobox.SelectedItem);

            int consumption = thisMonthNumber - lastMonthNumber;
            double price = 0;
            double envFee = 0;
            if (customerType == "Household customer")
            {
                decimal comsumptionPerPeople = consumption / numberOfPeople;
                if (comsumptionPerPeople <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                if (comsumptionPerPeople > 10 && comsumptionPerPeople <= 20)
                {
                    price = 7052;
                    envFee = 705.2;
                }
                if (comsumptionPerPeople > 20 && comsumptionPerPeople <= 30)
                {
                    price = 8699;
                    envFee = 866.90;
                }
                if (comsumptionPerPeople > 30)
                {
                    price = 15.929;
                    envFee = 1592.90;
                }
            }
            if (customerType == "Administrative agency public services") ;
            {
                price = 9955;
                envFee = 995.5;
            }
            if (customerType == "Production units") ;
            {
                price = 11615;
                envFee = 1161.5;
            }
            if (customerType == "Business services") ;
            {
                price = 22068;
                envFee = 2206.8;
            }
            double subTotal = price * consumption;
            double VATFee = (subTotal + envFee) * 0.1;
            double total = subTotal + envFee + VATFee;

            consumptionLabel.Text = consumption.ToString();
            priceLabel.Text = price.ToString();
            subTotalLabel.Text = Math.Round(subTotal, 2).ToString();
            envFeeLabel.Text = envFee.ToString();
            VATLabel.Text = Math.Round(VATFee).ToString();
            totalLabel.Text = Math.Round(total, 2).ToString();

            InvoicesManager.AddInvoice(customerCode, customerName, customerType,
                numberOfPeople, lastMonthNumber, thisMonthNumber, currentMonth, subTotal,
                 envFee, VATFee, total);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
