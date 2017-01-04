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
    public partial class Form_StoresIssuing : Form
    {
        public Form_StoresIssuing()
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

        private void b_addSI_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddSI fSI = new Form_AddSI();
            fSI.Show();
        }

        private void b_editSI_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EditGRNSelect fSI = new Form_EditGRNSelect();
            fSI.Show();
        }

        private void b_cancelSI_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CancelSI fSI = new Form_CancelSI();
            fSI.Show();
            
        }
    }
}
