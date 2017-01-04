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
    public partial class Form_EditPurchaseOrderSelect : Form
    {
        public Form_EditPurchaseOrderSelect()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form_PurchaseOrder fPO = new Form_PurchaseOrder();
            fPO.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EditPurchaseOrder fPO = new Form_EditPurchaseOrder();
            fPO.Show();
        }
    }
}
