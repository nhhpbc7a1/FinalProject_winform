using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class FormProduct : Form
    {
        List<Product> listProduct = new List<Product>();
        public FormProduct()
        {
            InitializeComponent();

            TakeAllProduct();
            Load_flowLayoutPanelProductList(listProduct);
            ProductFilterEvent();
        }
        void TakeAllProduct()
        {
            DataTable table = ProductDAO.LoadCanBuy();
            foreach (DataRow row in table.Rows)
            {
                listProduct.Add(ProductDAO.RowToProduct(row));
            }

        }
        private void Load_flowLayoutPanelProductList(List<Product> listP)
        {
            flowLayoutPanelProductList.Controls.Clear();
            foreach (Product x in listP)
            {
                if (x == null) continue;
                UCProductOnMainpage ucProduct = new UCProductOnMainpage(x);
                flowLayoutPanelProductList.Controls.Add(ucProduct);
                x.SearchCounter += 1;
                ProductDAO.CountingSearch(x);
                //MessageBox.Show(x.productId.ToString());
            }
        }


        public void LoadBySearchText(string x)
        {

            List<Product> listP = new List<Product>();
            listP.AddRange(listProduct);

            flowLayoutPanelProductList.Controls.Clear();
            listP = ProductDAO.SearchProducts(listP, x);

            Load_flowLayoutPanelProductList(listP);
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
            Product[] listP = listProduct.ToArray();

            if (cbMinPrice.Text != "" && cbMaxPrice.Text != "")
            {
                if (Convert.ToInt32(cbMinPrice.Text) > Convert.ToInt32(cbMaxPrice.Text))
                {
                    MessageBox.Show("Please input valid price");

                }
                else
                {
                    for (int i = 0; i < listP.Length; i++)
                    {
                        Product x = listP[i];
                        if (x.price > Convert.ToInt32(cbMaxPrice.Text) || x.price < Convert.ToInt32(cbMinPrice.Text))
                        {
                            listP[i] = null;
                        }
                    }
                }
            }
            List<string> categoryList = checkListBoxCategory.CheckedItems.OfType<string>().ToList();
            List<string> addressList = checkListBoxAddress.CheckedItems.OfType<string>().ToList();

            for (int i = 0; i < listP.Length; i++)
            {
                if (listP[i] == null) continue;
                Product x = listP[i];
                bool kt = false;
                if (categoryList.Count > 0)
                {
                    foreach (string category in categoryList)
                    {
                        if (x.category == category)
                        {
                            kt = true;
                            break;
                        }
                    }
                    if (kt == false)
                    {
                        listP[i] = null;
                        continue;
                    }
                }
                kt = false;
                if (addressList.Count > 0)
                {
                    kt = false;
                    foreach (string address in addressList)
                    {
                        if (UserDAO.SelectByUserId(x.sellerId).address == address)
                        {
                            kt = true;
                            break;
                        }
                    }
                    if (kt == false)
                    {
                        listP[i] = null;
                        continue;
                    }
                }
            }

            Load_flowLayoutPanelProductList(listP.ToList());
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
                MoveCheckedCategoryToFront(sender, e);
            }
        }
        private void MoveCheckedCategoryToFront(object sender, EventArgs e)
        {
            var checkedItems = checkListBoxCategory.CheckedItems.Cast<object>().ToArray();
            var uncheckedItems = checkListBoxCategory.Items.Cast<object>().Except(checkedItems).ToArray();

            checkListBoxCategory.Items.Clear();

            foreach (var item in checkedItems)
            {
                checkListBoxCategory.Items.Add(item, true);
            }

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
            var checkedItems = checkListBoxAddress.CheckedItems.Cast<object>().ToArray();
            var uncheckedItems = checkListBoxAddress.Items.Cast<object>().Except(checkedItems).ToArray();

            checkListBoxAddress.Items.Clear();

            foreach (var item in checkedItems)
            {
                checkListBoxAddress.Items.Add(item, true);
            }

            foreach (var item in uncheckedItems)
            {
                checkListBoxAddress.Items.Add(item, false);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
