﻿using System;
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
    public partial class Form_EditSI : Form
    {
        public Form_EditSI()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            //save itme request to db


            MessageBox.Show("New Advice of Dispatched Updated Successfully", "Update Advice of Dispatched", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form_StoresIssuing fSI = new Form_StoresIssuing();
            fSI.Show();
        }
    }
}
