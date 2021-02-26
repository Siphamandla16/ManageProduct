using BLL.Supplier;
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
    public partial class ManageSuppliers : MasterPage
    {
        public ManageSuppliers()
        {
            InitializeComponent();
            GridPopulate();
             
        }


        public void GridPopulate()
        {
            dataGridView1.DataSource = new SupplierLogic().GetSuppliers();
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSupplierID.Text)) return;
            new SupplierLogic().Save(new Supplier
            {
                Region = txtRegion.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                CompanyName = txtCompanyName.Text,
                ContactTitle = txtContactTitle.Text,
                Fax = txtFax.Text,
                HomePage = txtHomePage.Text,
                ContactName = txtContactName.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                PostalCode = txtPostalCode.Text
            });
            GridPopulate();
        }

        private void dtnUpdate_Click(object sender, EventArgs e)
        {
            new SupplierLogic().Update(new Supplier
            {
                Region = txtRegion.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                CompanyName = txtCompanyName.Text,
                ContactTitle = txtContactTitle.Text,
                Fax = txtFax.Text,
                HomePage = txtHomePage.Text,
                ContactName = txtContactName.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                PostalCode = txtPostalCode.Text,
                SupplierID = Convert.ToInt32(txtSupplierID.Text)
            });
            GridPopulate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new SupplierLogic().Delete(Convert.ToInt32(txtSupplierID.Text));
            GridPopulate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            txtSupplierID.Text = selectRow.Cells[0].Value.ToString();
            txtCompanyName.Text = selectRow.Cells[1].Value.ToString();
            txtContactName.Text = selectRow.Cells[2].Value.ToString();
            txtContactTitle.Text = selectRow.Cells[3].Value.ToString();
            txtAddress.Text = selectRow.Cells[4].Value.ToString();
            txtCity.Text = selectRow.Cells[5].Value.ToString();
            txtRegion.Text = selectRow.Cells[6].Value.ToString();
            txtPostalCode.Text = selectRow.Cells[7].Value.ToString();
            txtCountry.Text = selectRow.Cells[8].Value.ToString();
            txtPhone.Text = selectRow.Cells[9].Value.ToString();
            txtFax.Text = selectRow.Cells[10].Value.ToString();
            txtHomePage.Text = selectRow.Cells[11].Value.ToString();
        }
    }
}
