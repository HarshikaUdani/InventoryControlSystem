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
    public partial class Form_Items : Form
    {
        public Form_Items()
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

        private void b_addItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddItemRequest FMM = new Form_AddItemRequest();
            FMM.Show();
        }

        private void b_editItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EditItemRequestSelect FMM = new Form_EditItemRequestSelect();
            FMM.Show();
        }

        private void b_viewlItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CancelItemRequest FMCancel = new Form_CancelItemRequest();
            FMCancel.Show();
            
        }
    }
}
