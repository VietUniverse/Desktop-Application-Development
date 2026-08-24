using System;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public enum CustomerChoiceMode
    {
        NewCustomer,
        ExistingCustomer,
        GuestCheckout,
        Cancel
    }

    public partial class FormCustomerChoice : Form
    {
        public CustomerChoiceMode SelectedMode { get; private set; } = CustomerChoiceMode.Cancel;

        public FormCustomerChoice()
        {
            InitializeComponent();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            SelectedMode = CustomerChoiceMode.NewCustomer;
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnExistingCustomer_Click(object sender, EventArgs e)
        {
            SelectedMode = CustomerChoiceMode.ExistingCustomer;
            DialogResult = DialogResult.No;
            Close();
        }

        private void btnGuestCheckout_Click(object sender, EventArgs e)
        {
            SelectedMode = CustomerChoiceMode.GuestCheckout;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedMode = CustomerChoiceMode.Cancel;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
