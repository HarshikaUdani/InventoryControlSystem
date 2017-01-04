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
    public partial class Form_ViewItemRequest : Form
    {
        public Form_ViewItemRequest()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CancelItemRequest FItem = new Form_CancelItemRequest();
            FItem.Show();
        }
    }
}
