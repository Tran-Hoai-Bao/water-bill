using System.Security.Cryptography.X509Certificates;

namespace Copy
{
    public partial class Form1 : Form
    {
        public Invoices InvoiceManager;
        public Form1()
        {
            
            InitializeComponent();            
            InvoiceManager = new Invoices();

            addInvoice.InvoicesManager = InvoiceManager ;
            manageInvoice.InvoiceManager = InvoiceManager ;
            
            addInvoice.Show();
            manageInvoice.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addInvoice1_Load(object sender, EventArgs e)
        {

        }

        private void manageInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoice.Show();
            addInvoice.Hide();
            manageInvoice.RefreshInvoiceList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoice.Hide();
            addInvoice.Show();
        }
    }
}
