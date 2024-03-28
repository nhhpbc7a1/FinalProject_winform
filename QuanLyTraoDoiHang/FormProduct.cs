using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ProductDAO productDAO = new ProductDAO();
            DataTable table = productDAO.Load();
            foreach (DataRow row in table.Rows)
            {
                UCProductOnMainpage ucProduct = new UCProductOnMainpage(ProductDAO.RowToProduct(row));
                listProduct.Add(ProductDAO.RowToProduct(row));
                flowLayoutPanelProductList.Controls.Add(ucProduct);
            }
            ProductFilterEvent();
        }
        List<Product> listProduct = new List<Product>();
        public void LoadBySearchText(string x)
        {
            List<Product> SearchProducts(List<Product> productList, string searchString)
            {
                List<Product> relatedProducts = new List<Product>();
                foreach (Product product in productList)
                {
                    if (product.name.ToLower().Contains(searchString.ToLower()))
                    {
                        relatedProducts.Add(product);
                    }
                }
                return relatedProducts;
            }

            List<Product> listP = new List<Product>();
            ProductDAO productDAO = new ProductDAO();
            DataTable table = productDAO.Load();
            foreach (DataRow row in table.Rows)
            {
                listP.Add(ProductDAO.RowToProduct(row));
            }

            flowLayoutPanelProductList.Controls.Clear();
            listP = SearchProducts(listP, x);
            foreach (Product product in listP)
            {
                UCProductOnMainpage ucProduct = new UCProductOnMainpage(product);
                flowLayoutPanelProductList.Controls.Add(ucProduct);
            }
            listProduct = listP;
        }
        void ProductFilterEvent()
        {
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            cbAddress.SelectedIndexChanged += cbAddress_SelectedIndexChanged;
            //checkListBoxCategory.SelectedValueChanged += MoveCheckedCategoryToFront;
            //checkListBoxAddress.SelectedValueChanged += MoveCheckedAddressToFront;
            btnApply.Click += btnApply_Click;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            List<Product> listP = new List<Product>();
            listP.AddRange(listProduct);
            if (cbMinPrice.Text != "" && cbMaxPrice.Text != "")
            {
                if (Convert.ToInt32(cbMinPrice.Text) > Convert.ToInt32(cbMaxPrice.Text))
                {
                    MessageBox.Show("Please input valid price");
                    
                }
                else
                {
                    while (true)
                    {
                        bool kt = false;
                        int i = 0;
                        foreach (Product x in listP)
                        {
                            if (x.price > Convert.ToInt32(cbMaxPrice.Text) || x.price < Convert.ToInt32(cbMinPrice.Text))
                            {
                                listP.Remove(x);
                                kt = true;
                                break;
                            }
                            i++;
                        }
                        if (kt == false) break;
                    }
                }
            }
            List<string> categoryList = checkListBoxCategory.CheckedItems.OfType<string>().ToList();
            List<string> addressList = checkListBoxAddress.CheckedItems.OfType<string>().ToList();
            while (true)
            {
                bool kt = true;
                foreach (Product x in listP)
                {
                    foreach (string category in categoryList)
                        if (x.category != category)
                        {
                            listP.Remove(x);
                            kt = false;
                            break;
                        }
                    if (kt == false) break;
                    foreach (string address in addressList)
                        if (UserDAO.SelectByUserId(x.sellerId).address != address)
                        {
                            listP.Remove(x);
                            kt = false;
                            break;
                        }
                    if (kt == false) break;
                }
                if (kt == true)
                    break;
            }
            flowLayoutPanelProductList.Controls.Clear();
            foreach (Product product in listP)
            {
                UCProductOnMainpage ucProduct = new UCProductOnMainpage(product);
                flowLayoutPanelProductList.Controls.Add(ucProduct);
            }

        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool kt = false;
            int i = 0;
            foreach (string x in checkListBoxCategory.Items)
            {
                i++;
                if (cbCategory.SelectedItem == x)
                {
                    kt = true;
                    checkListBoxCategory.SetItemChecked(i - 1, true);
                    break;
                }
            }
            if (kt == false)
            {
                checkListBoxCategory.Items.Add(cbCategory.SelectedItem);
                checkListBoxCategory.SetItemChecked(checkListBoxCategory.Items.Count - 1, true);
                MoveCheckedCategoryToFront(sender,e);
            }
        }
        private void MoveCheckedCategoryToFront(object sender, EventArgs e)
        {
            // Get the checked items and unchecked items
            var checkedItems = checkListBoxCategory.CheckedItems.Cast<object>().ToArray();
            var uncheckedItems = checkListBoxCategory.Items.Cast<object>().Except(checkedItems).ToArray();

            // Clear the CheckBoxList
            checkListBoxCategory.Items.Clear();

            // Add the checked items first
            foreach (var item in checkedItems)
            {
                checkListBoxCategory.Items.Add(item, true);
            }

            // Add the unchecked items after checked items
            foreach (var item in uncheckedItems)
            {
                checkListBoxCategory.Items.Add(item, false);
            }
        }
        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool kt = false;
            int i = 0;
            foreach (string x in checkListBoxAddress.Items)
            {
                i++;
                if (cbAddress.SelectedItem == x)
                {
                    kt = true;
                    checkListBoxAddress.SetItemChecked(i - 1, true);
                    break;
                }
            }
            if (kt == false)
            {
                checkListBoxAddress.Items.Add(cbAddress.SelectedItem);
                checkListBoxAddress.SetItemChecked(checkListBoxAddress.Items.Count - 1, true);
                MoveCheckedAddressToFront(sender, e);
            }


        }
        private void MoveCheckedAddressToFront(object sender, EventArgs e)
        {
            // Get the checked items and unchecked items
            var checkedItems = checkListBoxAddress.CheckedItems.Cast<object>().ToArray();
            var uncheckedItems = checkListBoxAddress.Items.Cast<object>().Except(checkedItems).ToArray();

            // Clear the CheckBoxList
            checkListBoxAddress.Items.Clear();

            // Add the checked items first
            foreach (var item in checkedItems)
            {
                checkListBoxAddress.Items.Add(item, true);
            }

            // Add the unchecked items after checked items
            foreach (var item in uncheckedItems)
            {
                checkListBoxAddress.Items.Add(item, false);
            }
        }

    }
}
