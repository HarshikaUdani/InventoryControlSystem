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
    public partial class Form_EditSISelect : Form
    {
        public Form_EditSISelect()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form_StoresIssuing fSI = new Form_StoresIssuing();
            fSI.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_EditSI fGRN = new Form_EditSI();
            fGRN.Show();
        }
    }
}
