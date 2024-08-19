using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using static Assignment2.Form1;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public List<Invoice> Invoices = new List<Invoice>();
        public const double VAT = 0.1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLoad1_Enter(object sender, EventArgs e)
        {


        }

        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TypeOfCustomer = cboTypeOfCustomer.Text;
            if (TypeOfCustomer.Equals("Household customer"))
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }


        private (double, double) Calculator(string TypeOfCustomer, int NumberOfFamily, double LastMonthWater, double ThisMonthWater)
        {
            double Consumption = ThisMonthWater - LastMonthWater;
            double WaterMoney;
            if (TypeOfCustomer.Equals("Household customer"))
            {
                double AverageWaterUsed = Consumption / NumberOfFamily;
                WaterMoney = BillWaterForHouseHold(AverageWaterUsed, Consumption);
            }
            else if (TypeOfCustomer.Equals("Adminstration agency, public services"))
            {
                WaterMoney = (Consumption * 9955);
                WaterMoney += (WaterMoney * VAT);
            }
            else if (TypeOfCustomer.Equals("Production units"))
            {
                WaterMoney = (Consumption * 11615);
                WaterMoney += (WaterMoney * VAT);
            }
            else
            {
                WaterMoney = (Consumption * 22086);
                WaterMoney += (WaterMoney * VAT);
            }
            return (Consumption, WaterMoney);
        }
        private double BillWaterForHouseHold(double AverageWaterUsed, double Consumption)
        {
            //  Calculate the amount of water consumed this month according to household conditions
            double WaterMoney = 0;
            if (AverageWaterUsed > 0 && AverageWaterUsed < 10)
            {
                WaterMoney = Consumption * 5973;
            }
            else if (AverageWaterUsed >= 10 && AverageWaterUsed < 20)
            {
                WaterMoney = Consumption * 7052;
            }
            else if (AverageWaterUsed >= 20 && AverageWaterUsed < 30)
            {
                WaterMoney = Consumption * 8699;
            }
            else
            {
                WaterMoney = Consumption * 15929;
            }
            return WaterMoney + WaterMoney * VAT;
        }

        private void TypeOfCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {

            string CustomerName = txtCustomerName.Text.Trim();
            string typeOfCustomer = cboTypeOfCustomer.Text;
            int numberOfPeople = 0; //Convert.ToInt32(txt);
            double lastMonth = 0;
            double thisMonth = 0;
            if (true)
            {
                if (CustomerName == "" || CustomerName == null)
                {
                    MessageBox.Show("Please enter customer name.", "ValidationConstraints Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(typeOfCustomer))
                {
                    MessageBox.Show("Please select type of customer", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (typeOfCustomer.Equals("Household customer"))
                {
                    if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                    {
                        MessageBox.Show("Number of member must be a positive integer for household customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (!double.TryParse(txtLastMonthWater.Text, out lastMonth) || lastMonth <= 0)
                {
                    MessageBox.Show("Last month water meter should be a positvie number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!double.TryParse(txtThisMonthWater.Text, out thisMonth) || thisMonth <= 0)
                {
                    MessageBox.Show("This month water meter should be a positvie number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (thisMonth < lastMonth)
            {
                MessageBox.Show("Something wrong here, try again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ShowBill = Calculator(typeOfCustomer, numberOfPeople, lastMonth, thisMonth);
            ListViewItem item = new ListViewItem(CustomerName);
            item.SubItems.Add(typeOfCustomer.ToString());
            item.SubItems.Add(numberOfPeople.ToString());
            item.SubItems.Add(lastMonth.ToString());
            item.SubItems.Add(thisMonth.ToString());
            item.SubItems.Add(ShowBill.Item1.ToString());
            item.SubItems.Add(ShowBill.Item2.ToString());
            lvInvoice.Items.Add(item);

            Invoice invoice = new Invoice
            {
                CustomerName = CustomerName,
                TypeOfCustomer = typeOfCustomer,
                NumberOfPeople = numberOfPeople,
                LastMonth = lastMonth,
                ThisMonth = thisMonth,
                Consumption = ShowBill.Item1,
                WaterMoney = ShowBill.Item2,

            };
            Invoices.Add(invoice);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvInvoice.SelectedItems.Count > 0)
            {
                var ExportBill = lvInvoice.SelectedItems[0].SubItems;
                Invoice invoice = new Invoice
                {
                    /*
                     * This function displays the water bill consumed this month and customer information
                     * */
                    CustomerName = ExportBill[0].Text,
                    TypeOfCustomer = ExportBill[1].Text,
                    NumberOfPeople = Convert.ToInt32(ExportBill[2].Text),
                    LastMonth = Convert.ToDouble(ExportBill[3].Text),
                    ThisMonth = Convert.ToDouble(ExportBill[4].Text),
                    Consumption = Convert.ToDouble(ExportBill[5].Text),
                    WaterMoney = Convert.ToDouble(ExportBill[6].Text),
                };
                Form2 form2 = new Form2(invoice);
                form2.ShowDialog();
            }

        }

        private void txtLastMonthWater_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThisMonthWater_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchText = txtSearch.Text.Trim();
            lvInvoice.Items.Clear();
            bool Foundresult = false;
            if (SearchText == "")
            {
                foreach (Invoice invoice in Invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.TypeOfCustomer.ToString());
                    item.SubItems.Add(invoice.NumberOfPeople.ToString());
                    item.SubItems.Add(invoice.LastMonth.ToString());
                    item.SubItems.Add(invoice.ThisMonth.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvInvoice.Items.Add(item);
                }
                Foundresult = true;
            }
            else
            {
                foreach (Invoice invoice in Invoices)
                {
                    if (invoice.CustomerName.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0 && !string.IsNullOrEmpty(invoice.CustomerName))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.TypeOfCustomer.ToString());
                        item.SubItems.Add(invoice.NumberOfPeople.ToString());
                        item.SubItems.Add(invoice.LastMonth.ToString());
                        item.SubItems.Add(invoice.ThisMonth.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvInvoice.Items.Add(item);
                        Foundresult = true;
                    }
                }

            }
            if (!Foundresult)
            {
                ListViewItem item = new ListViewItem("No information");
                lvInvoice.Items.Clear();
                lvInvoice.Items.Add(item);
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvInvoice.View = View.Details;
            lvInvoice.Columns.Add("Customer Name", 200);
            lvInvoice.Columns.Add("TypeOfCustomer", 150);
            lvInvoice.Columns.Add("Number of People", 150);
            lvInvoice.Columns.Add("Last Month Water Meter", 200);
            lvInvoice.Columns.Add("This Month Water Meter", 200);
            lvInvoice.Columns.Add("Amount Of Consumption", 200);
            lvInvoice.Columns.Add("Total Water Bill", 200);
            lvInvoice.View = View.Details;
            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administration agency, pbulic services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");
        }

        private void buttonexport_Click(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }
    }
    public class Invoice
    {
        public string CustomerName { get; set; }
        public string TypeOfCustomer { get; set; }
        public int NumberOfPeople { get; set; }
        public double LastMonth { get; set; }
        public double ThisMonth { get; set; }
        public double Consumption { get; set; }
        public double WaterMoney { get; set; }

    }
}