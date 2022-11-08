using GerenciarClientes.Properties;
using GerenciarClientes.Repository;
using MetroFramework.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarClientes
{
    public partial class NewCustomer : MetroForm
    {
        private string currDate = string.Empty;
        MainView MainView;
        public NewCustomer(MainView mainView)
        {
            InitializeComponent();
            MainView = mainView;
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }
        
        private void materialTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(CVisityHistoryListView.FindItemWithText(metroDateTime1.Text));
            if (CVisityHistoryListView.FindItemWithText(metroDateTime1.Text) == null)
            {
                CVisityHistoryListView.Items.Add(metroDateTime1.Text);
                helperLbl.Text = "";
            }
            else
            {
                helperLbl.Text = "Erro: Data já adicionada.";
            }
        }

        private void registerCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var currDate = DateTime.Now.ToString("yyyy/MM/dd");
                Customer customer = new Customer();
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
                
                CustomerRepository.Insert(customer);
                MainView.customerGridLoad();
                this.Close();
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
                MessageBox.Show(error.ToString());
            }
        }
    }
}
