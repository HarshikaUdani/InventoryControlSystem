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
    public partial class Form_GRN : Form
    {
        public Form_GRN()
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

        private void b_addGRN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddGRN fPO = new Form_AddGRN();
            fPO.Show();
        }

        private void b_editGRN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EditGRNSelect fPO = new Form_EditGRNSelect();
            fPO.Show();
        }

        private void b_cancelGRN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CancelGRN fPO = new Form_CancelGRN();
            fPO.Show();
            
        }
    }
}
