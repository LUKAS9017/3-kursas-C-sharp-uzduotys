using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CategoryForm : Form
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public CategoryForm(string currentName, string currentType)
        {
            InitializeComponent();
            txtCategoryName.Text = currentName;
            cboCategoryType.Text = currentType;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Name = txtCategoryName.Text;
            Type = cboCategoryType.Text; // Naujas laukas kategorijos tipo pasirinkimui
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
