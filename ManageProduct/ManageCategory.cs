using BLL.Catergory;
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
    public partial class ManageCategory : MasterPage
    {
     
        public ManageCategory()
        {
            InitializeComponent();
            SetGrid();
        }


        public void SetGrid()
        {
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = new CategoryLogic().GetCatergories();
        }


        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCategoryID.Text)) return;
                new CategoryLogic().Save(new Catergory
                {
                    CategoryName = txtCategoryName.Text,
                    Description = txtDescription.Text,
                    Picture = null
                });
                SetGrid();
            }
            catch (Exception ex)
            {
                throw;
            }
      
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            txtCategoryID.Text = selectRow.Cells[0].Value.ToString();
            txtCategoryName.Text = selectRow.Cells[1].Value.ToString();
            txtDescription.Text = selectRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                new CategoryLogic().Update(new Catergory
                {
                    CategoryID = Convert.ToInt32(txtCategoryID.Text),
                    CategoryName = txtCategoryName.Text,
                    Description = txtDescription.Text,
                    Picture = null
                });
                SetGrid();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new CategoryLogic().Delete(Convert.ToInt32(txtCategoryID.Text));
            SetGrid();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            
        }
    }
}
