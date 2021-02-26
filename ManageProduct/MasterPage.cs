using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProduct
{
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            var product =  new ManageProduct();
            product.Show();

            this.Visible = false;
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            var suppliers = new ManageSuppliers();
            suppliers.Show();

            this.Visible = false;
        }

        private void btnCatergory_Click(object sender, EventArgs e)
        {
            var category = new ManageCategory();
            category.Show();

            this.Visible = false;
        }
    }
}
