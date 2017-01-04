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
    public partial class Form_CancelSI : Form
    {
        public Form_CancelSI()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel this Advice of Dispatched?", "Cancel Advice of Dispatched", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //to do:change status to cancel

                MessageBox.Show("Advice of Dispatched cancelled Successfully", "Cancel Advice of Dispatched");
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_StoresIssuing fGRN = new Form_StoresIssuing();
            fGRN.Show();
        }

        private void b_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ViewSI FItem = new Form_ViewSI();
            FItem.Show();

        }
    }
}
