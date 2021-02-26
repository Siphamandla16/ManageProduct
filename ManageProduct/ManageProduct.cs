using BLL.Catergory;
using BLL.Product;
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
    public partial class ManageProduct : MasterPage
    {
        public ManageProduct()
        {
            InitializeComponent();
            PopulatedDropdown();
            GridPopulate();
        }


        public void GridPopulate()
        {
            dataGridViewProduct.DataSource = new ProductLogic().GetProducts();
        }
        public void PopulatedDropdown()
        {
           
            cbSupplierBox.DataSource = new SupplierLogic().GetSuppliers().ToList();
            cbSupplierBox.DisplayMember = nameof(Supplier.CompanyName);
            cbSupplierBox.ValueMember = nameof(Supplier.SupplierID);

            cbCategoryBox.DataSource = new CategoryLogic().GetCatergories().ToList();
            cbCategoryBox.DisplayMember = nameof(Catergory.CategoryName);
            cbCategoryBox.ValueMember = nameof(Catergory.CategoryID);

        }

    
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridViewProduct.Rows[index];
            txtProductId.Text = selectRow.Cells[0].Value.ToString();
            txtProductName.Text = selectRow.Cells[1].Value.ToString();
            cbSupplierBox.SelectedItem = selectRow.Cells[2].Value.ToString();
            cbCategoryBox.SelectedItem = selectRow.Cells[3].Value.ToString();
            txtQuantityPerUnit.Text = selectRow.Cells[4].Value.ToString();
            txtUnitPrice.Text = selectRow.Cells[5].Value.ToString();
            txtUnitsInStock.Text = selectRow.Cells[6].Value.ToString();
            txtUnitsOnOrder.Text = selectRow.Cells[7].Value.ToString();
            txtReorderLevel.Text = selectRow.Cells[8].Value.ToString();
            rbNo.Checked = Convert.ToBoolean(selectRow.Cells[9].Value) == false ? true : false;
            rbYes.Checked = Convert.ToBoolean(selectRow.Cells[9].Value) == true ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductId.Text)) return;
            new ProductLogic().Save(new Product
            {
                ProductName = txtProductName.Text,
                SupplierID = ((Supplier)cbSupplierBox.SelectedItem).SupplierID,
                CategoryID = ((Catergory)cbCategoryBox.SelectedItem).CategoryID,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                Discontinued = Convert.ToBoolean(rbYes.Checked == true ? true: false),
                ReorderLevel = Convert.ToInt32(txtReorderLevel.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text),
                UnitsOnOrder = Convert.ToInt32(txtUnitsOnOrder.Text)

            });

            GridPopulate();
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            rbNo.Checked = false;
            rbYes.Checked = true;

        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            rbYes.Checked = false;
            rbNo.Checked = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new ProductLogic().Update(new Product
            {
                ProductID = Convert.ToInt32(txtProductId.Text),
                ProductName = txtProductName.Text,
                SupplierID = ((Supplier)cbSupplierBox.SelectedItem).SupplierID,
                CategoryID = ((Catergory)cbCategoryBox.SelectedItem).CategoryID,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                Discontinued = Convert.ToBoolean(rbYes.Checked == true ? true : false),
                ReorderLevel = Convert.ToInt32(txtReorderLevel.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text),
                UnitsOnOrder = Convert.ToInt32(txtUnitsOnOrder.Text)

            });
            GridPopulate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new ProductLogic().Delete(Convert.ToInt32(txtProductId.Text));
            GridPopulate();
        }
    }
}
