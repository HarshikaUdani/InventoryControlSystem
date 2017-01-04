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
    public partial class Form_ViewSI : Form
    {
        public Form_ViewSI()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form_CancelSI fGRN = new Form_CancelSI();
            fGRN.Show();
        }
    }
}
