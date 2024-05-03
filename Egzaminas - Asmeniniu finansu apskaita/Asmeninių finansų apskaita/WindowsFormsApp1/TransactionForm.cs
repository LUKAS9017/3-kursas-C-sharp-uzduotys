using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1
{
    public partial class TransactionForm : Form
    {
        public decimal Amount { get; private set; }
        public int CategoryID { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }
        public TransactionForm(decimal initialAmount, int initialCategoryID, DateTime initialDate, string initialDescription)
        {
            InitializeComponent();

            // Priskiriame pradines reiksmes
            Amount = initialAmount;
            CategoryID = initialCategoryID;
            Date = initialDate;
            Description = initialDescription;

            // Nustatome formos laukus pagal pradines reiksmes
            txtAmount.Text = initialAmount.ToString();
            txtCategoryID.Text = initialCategoryID.ToString();
            dtpDate.Value = initialDate;
            txtDescription.Text = initialDescription;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            Amount = decimal.Parse(txtAmount.Text);
            CategoryID = int.Parse(txtCategoryID.Text);
            Date = dtpDate.Value;
            Description = txtDescription.Text;

            // Uždaryti formą
            DialogResult = DialogResult.OK;
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
