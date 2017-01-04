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
    public partial class Form_CancelItemRequest : Form
    {
        public Form_CancelItemRequest()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel this item request?", "Cancel Item Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //to do:change status of item request to cancel

                MessageBox.Show("Item request cancelled Successfully", "Cancel Item Request");
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ItemRequest FItem = new Form_ItemRequest();
            FItem.Show();
        }

        private void b_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ViewItemRequest FItem = new Form_ViewItemRequest();
            FItem.Show();

        }
    }
}
