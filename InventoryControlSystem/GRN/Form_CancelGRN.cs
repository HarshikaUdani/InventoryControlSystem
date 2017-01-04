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
    public partial class Form_CancelGRN : Form
    {
        public Form_CancelGRN()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel this Good Received Note?", "Cancel Good Received Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //to do:change status of item request to cancel

                MessageBox.Show("Good Received Note cancelled Successfully", "Cancel Good Received Note");
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_GRN fGRN = new Form_GRN();
            fGRN.Show();
        }

        private void b_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ViewGRN FItem = new Form_ViewGRN();
            FItem.Show();

        }
    }
}
