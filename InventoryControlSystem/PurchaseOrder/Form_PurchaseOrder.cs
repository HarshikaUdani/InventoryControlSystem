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
    public partial class Form_PurchaseOrder : Form
    {
        public Form_PurchaseOrder()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_mainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MainMenu FMM = new Form_MainMenu();
            FMM.Show();
        }

        private void b_addPO_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddPurchaseOrder fPO = new Form_AddPurchaseOrder();
            fPO.Show();
        }

        private void b_editPO_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EditPurchaseOrderSelect fPO = new Form_EditPurchaseOrderSelect();
            fPO.Show();
        }

        private void b_cancelPO_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CancelPurchaseOrder fPO = new Form_CancelPurchaseOrder();
            fPO.Show();
            
        }
    }
}
