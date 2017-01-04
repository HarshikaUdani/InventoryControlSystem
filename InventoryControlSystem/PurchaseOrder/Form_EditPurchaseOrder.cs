using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControlSystem
{
    public partial class Form_EditPurchaseOrder : Form
    {
        public Form_EditPurchaseOrder()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            //save itme request to db


            MessageBox.Show("Purchase Order updated Successfully", "Update Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
            //Form_ItemRequest FItem = new Form_ItemRequest();
           // FItem.Show();

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form_PurchaseOrder fPO = new Form_PurchaseOrder();
            fPO.Show();
        }
    }
}
