namespace WinFormsApp3
{
    public partial class MainForm : Form
    {
        public Invoice invoiceManager;

        public MainForm()
        {
            InitializeComponent();
            invoiceManager = new Invoice();

            addInvoice.InvoiceManager = invoiceManager;
            manageInvoices.InvoiceManager = invoiceManager;

            addInvoice.Show();
            manageInvoices.Hide();
        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Show();
            addInvoice.Hide();
            manageInvoices.RefreshInvoiceList();
        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Hide();
            addInvoice.Show();
        }

        private void addInvoice_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
