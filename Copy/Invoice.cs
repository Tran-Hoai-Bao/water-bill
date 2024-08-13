using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy
{
    public class Invoices
    {
        List<Invoices> invoices = new List<Invoices>();
        public string customerCode { get; set; }
        public string customerName { get; set; }
        public string customerType { get; set; }
        public int numberOfPeople { get; set; }
        public int lastMonthNumber { get; set;}
        public int thisMonthNumber { get; set;}
        public int month { get; set;}
        public double subTotal { get; set;}
        public double envFee { get; set;}
        public double VATFee { get; set;}
        public double total { get; set;}
        public Invoices() 
        {
        
        }
        public Invoices(string customerCode, string customerName, string customerType, int numberOfPeople, int lastMonthNumber,int thisMonthNumber, int month, double subTotal, double envFee, double vATFee, double total)
        {
            this.customerCode = customerCode;
            this.customerName = customerName;
            this.customerType = customerType;
            this.numberOfPeople = numberOfPeople;
            this.lastMonthNumber = lastMonthNumber;
            this.month = month;
            this.subTotal = subTotal;
            this.envFee = envFee;
            VATFee = vATFee;
            this.total = total;
        }
        public void AddInvoice(string customerCode, string customerName,
        string customerType, int numberOfPheople, int LastMonthNumber,
        int thisMonthNumber,
        int month, double subTotal, double envFee, double VATFee, double total)
        {
            Invoices invoice = new Invoices(customerCode, customerName, customerType
            , numberOfPheople, lastMonthNumber,thisMonthNumber, month, subTotal,
            envFee, VATFee, total);
            invoices.Add(invoice);
        }
        public List<Invoices> GetListInvoices()
        {
            return invoices;
        }
    }
    
}
