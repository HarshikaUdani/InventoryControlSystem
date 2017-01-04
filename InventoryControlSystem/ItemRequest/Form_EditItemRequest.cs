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
    public partial class Form_EditItemRequest : Form
    {
        public Form_EditItemRequest()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form_ItemRequest FItem = new Form_ItemRequest();
            FItem.Show();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            //TODO: update db

            MessageBox.Show("Item Request Updated Successfully", "Update Item Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
            //Form_ItemRequest FItem = new Form_ItemRequest();
            //FItem.Show();
        }
    }
}
