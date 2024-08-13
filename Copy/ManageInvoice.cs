using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copy
{
    public partial class ManageInvoice : UserControl
    {
        public Invoices InvoiceManager { get; set; }
        public ManageInvoice()
        {
            InitializeComponent();
        }
        public void RefreshInvoiceList()
        {
            if (InvoiceManager != null)
            {
                List<Invoices> invoices = InvoiceManager.GetListInvoices();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("No");
                dataTable.Columns.Add("Customer Code");
                dataTable.Columns.Add("Customer Name");
                dataTable.Columns.Add("Customer Type");
                dataTable.Columns.Add("Month");
                dataTable.Columns.Add("Last Month");
                dataTable.Columns.Add("This Month");
                dataTable.Columns.Add("Total");
                int i = 1;
                foreach (var invoice in invoices)
                {
                    dataTable.Rows.Add(
                        i++,
                        invoice.customerCode,
                        invoice.customerName,
                        invoice.customerType,
                        invoice.month,
                        invoice.lastMonthNumber,
                        invoice.thisMonthNumber,                     
                        invoice.total
                    );
                }

                invoicesDataGridView.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
