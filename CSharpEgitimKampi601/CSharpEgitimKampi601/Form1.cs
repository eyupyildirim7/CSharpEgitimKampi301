using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        CustomerOperations customerOperations = new CustomerOperations();

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname= txtCustomerSurname.Text,
                CustomerBalence=decimal.Parse(txtCustomerBalance.Text),
                CustomerCity= txtCustomerCity.Text,
                CustomerShoppingCount=int.Parse(txtCustomerCount.Text),
            };
            customerOperations.AddCustomer(customer);
            MessageBox.Show("Musteri Ekleme Islemi Basarili", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            dataGridView1.DataSource=customers;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            string customerId=txtCustomerId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Musteri Basariyla Silindi.");

        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string id =txtCustomerId.Text;
            var updateCustomer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerBalence = decimal.Parse(txtCustomerBalance.Text),
                CustomerCity = txtCustomerCity.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerShoppingCount = int.Parse(txtCustomerCount.Text),
                CustomerId=id

            };
            customerOperations.UpdateCustomer(updateCustomer);
            MessageBox.Show("Musteri Basariyla Guncellendi.");

        }

        private void btnGetByCustomerId_Click(object sender, EventArgs e)
        {
            string id=txtCustomerId.Text;
            Customer customer=customerOperations.GetCustomerById(id);
            dataGridView1.DataSource=new List<Customer>{customer};
        }
    }
}
