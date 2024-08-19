using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form2 : Form
    {
        public Form2(Invoice invoice)
        {
            InitializeComponent();
            labelcustomername.Text = invoice.CustomerName;
            labeltypeofcustomer.Text = invoice.TypeOfCustomer;
            labelnumberofpeople.Text = invoice.NumberOfPeople.ToString();
            labellastmonth.Text = invoice.LastMonth.ToString();
            labelthismonth.Text = invoice.ThisMonth.ToString();
            labelconsumption.Text = (invoice.Consumption.ToString() + "m³");
            labeltotalwater.Text = (invoice.WaterMoney.ToString() + "VND");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
