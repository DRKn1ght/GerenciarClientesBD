using MaterialSkin;
using MaterialSkin.Controls;
using GerenciarClientes.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using GerenciarClientes.Repository;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Globalization;

namespace GerenciarClientes
{
    public partial class MainView : MetroForm
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerGridLoad();
        }

        public void customerGridLoad()
        {
            metroGrid1.Rows.Clear();
            List<Customer> allCustomers = CustomerRepository.GetAll();
            foreach (Customer customer in allCustomers)
            {
                metroGrid1.Rows.Add(customer.Name, customer.CPF, customer.Phone, customer.Description, customer.VisitCount);
            }
            CustomerTabPage.Text = "Clientes (" + allCustomers.Count() + ")";
            CustomerTabControl.SelectedIndex = 0;
        }

        private void metroGrid1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 5)
                Cursor.Current = Cursors.Hand;
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            NewCustomer newCostumer = new NewCustomer(this);
            newCostumer.Show();
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string CPF = metroGrid1[1, e.RowIndex].Value.ToString();
            CustomerDetails customerDetails = new CustomerDetails(CPF, this);
            customerDetails.Show();
        }

        private void metroGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string CPF = metroGrid1[1, e.RowIndex].Value.ToString();
                CustomerDetails customerDetails = new CustomerDetails(CPF, this);
                customerDetails.Show();
            }
            if (e.ColumnIndex == 6)
            {
                string CPF = metroGrid1[1, e.RowIndex].Value.ToString();
                DialogResult dialogResult = MessageBox.Show($"Os dados do cliente {metroGrid1[0, e.RowIndex].Value} serão deletados.\nContinuar?", "Aviso!" , MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CustomerRepository.Delete(CPF);
                    customerGridLoad();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            OptionConfig optionConfig = new OptionConfig();
            optionConfig.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FilteringOptions filteringOptions = new FilteringOptions();
            filteringOptions.Show();
        }

        private void metroGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string CPF = metroGrid1[1, e.RowIndex].Value.ToString();
            CustomerDetails customerDetails = new CustomerDetails(CPF, this);
            customerDetails.Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<Customer> allCustomers;
            if (NameCb.Checked)
            {
                allCustomers = CustomerRepository.GetAnyByName(searchText.Text);
            }
            else
            {
                allCustomers = CustomerRepository.GetAnyByCPF(searchText.Text);
            }
            metroGrid1.Rows.Clear();
            foreach (Customer customer in allCustomers)
            {
                metroGrid1.Rows.Add(customer.Name, customer.CPF, customer.Phone, customer.Description, customer.VisitCount);
            }
            CustomerTabPage.Text = "Clientes (" + allCustomers.Count() + ")";
            CustomerTabControl.SelectedIndex = 0;
        }
    }
}
