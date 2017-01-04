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
    public partial class Form_AddGRN : Form
    {
        public Form_AddGRN()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            //save itme request to db


            MessageBox.Show("New Good Received Note Inserted Successfully", "New Good Received Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form_GRN fGRN = new Form_GRN();
            fGRN.Show();
        }
    }
}
