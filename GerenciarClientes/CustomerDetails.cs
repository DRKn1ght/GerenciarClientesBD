using GerenciarClientes.Repository;
using MetroFramework.Forms;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarClientes
{
    public partial class CustomerDetails : MetroForm
    {
        private string CustomerCPF;
        private ObjectId CustomerID;
        MainView MainView;
        public CustomerDetails(string CPF, MainView mainView)
        {
            InitializeComponent();
            CustomerCPF = CPF;
            MainView = mainView;
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            Customer customer = CustomerRepository.GetByCPF(CustomerCPF);
            CustomerID = customer._id;
            CNameTxt.Text = customer.Name;
            CCPFTxt.Text = customer.CPF;
            CPhoneTxt.Text = customer.Phone;
            CDescTxt.Text = customer.Description;
            CPublishDateTxt.Text = customer.PublishDate;
            CNumVisitsTxt.Text = customer.VisitCount.ToString();
            foreach (string item in customer.VisitHistory)
            {
                CVisityHistoryListView.Items.Add(item);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var currDate = DateTime.Now.ToString("yyyy/MM/dd");
                Customer customer = new Customer();
                customer._id = CustomerID;
                customer.Name = CNameTxt.Text;
                customer.CPF = CCPFTxt.Text;
                customer.Phone = CPhoneTxt.Text;
                customer.Description = CDescTxt.Text;
                customer.PublishDate = currDate;
                customer.VisitCount = int.Parse(CNumVisitsTxt.Text);
                customer.VisitHistory = new List<string>();
                foreach (ListViewItem item in CVisityHistoryListView.Items)
                {
                    customer.VisitHistory.Add(item.Text);
                }
                CustomerRepository.Update(CustomerCPF, customer);
                MainView.customerGridLoad();
                this.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                MessageBox.Show(error.ToString());
            }
        }
    }
}
