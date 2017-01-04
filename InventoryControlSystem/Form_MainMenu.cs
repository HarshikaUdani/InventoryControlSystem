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
    public partial class Form_MainMenu : Form
    {
        public Form_MainMenu()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_itemRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ItemRequest fItem = new Form_ItemRequest();
            fItem.Show();
        }

        private void b_purchaseOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_PurchaseOrder fPO = new Form_PurchaseOrder();
            fPO.Show();
        }

        private void b_GRN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_GRN fGRN = new Form_GRN();
            fGRN.Show();
        }

        private void b_storesIssue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_StoresIssuing fSI = new Form_StoresIssuing();
            fSI.Show();
        }
        
    }
}
