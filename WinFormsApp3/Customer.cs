using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Customer
    {
        public string customerCode { get; set; }
        public string customerName { get; set; }
        public string customerType { get; set; }
        public int numberOfPeople { get; set; }
        public int lastMonthNumber { get; set; }
        public int thisMonthNumber { get; set; }
        public int month { get; set; }
        public double subTotal { get; set; }
        public double envFee { get; set; }
        public double VATFee { get; set; }
        public double total { get; set; }

        public List<Customer> customers = new List<Customer>();

        public Customer(string code, string customerName, string customerType,
            int numberOfPeople, int lastMonthNumber, 
            int thisMonthNumber, int month, double subTotal,
            double envFee, double VATFee, double total)
        {
            this.customerCode = code;
            this.customerName = customerName;
            this.customerType = customerType;
            this.numberOfPeople = numberOfPeople;
            this.lastMonthNumber = lastMonthNumber;
            this.thisMonthNumber = thisMonthNumber;
            this.month = month;
            this.subTotal = subTotal;
            this.envFee = envFee;
            this.VATFee = VATFee;
            this.total = total;
        }

        public Customer()
        {

        }
        public void AddInvoice(string customerCode, string customerName,
            string customerType, int numberOfPeople,
            int lastMonthNumber, int thisMonthNumber, int month, 
            double subTotal, double envFee, double VATFee, double total)
        {
            Customer customer = new Customer(customerCode, customerName, customerType,
                numberOfPeople, lastMonthNumber, thisMonthNumber
                , month, subTotal,envFee,VATFee,total);
            customers.Add(customer);
        }
        public List<Customer> GetInvoices(string keyword = "")
        {
            if (keyword != "")
                return customers.Where(x => x.customerCode.Contains(keyword) || x.customerName.Contains(keyword)).ToList();
            else
                return customers;
        }
        public dynamic GetInvoice(string customerCode, int month)
        {
            // Find the invoice by customerCode and month
            var invoice = customers.FirstOrDefault(c => c.customerCode == customerCode && c.month == month);
            return invoice;
        }
    }
}
