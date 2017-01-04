using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryControlSystem
{
    public partial class Form_CancelPurchaseOrder : Form
    {
        public Form_CancelPurchaseOrder()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel this purchase order?", "Cancel Purchase Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //to do:change status of item request to cancel

                MessageBox.Show("Purchase order cancelled Successfully", "Cancel Purchase Order");
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_PurchaseOrder FItem = new Form_PurchaseOrder();
            FItem.Show();
        }

        private void b_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ViewPurchaseOrder FItem = new Form_ViewPurchaseOrder();
            FItem.Show();

        }
    }
}
