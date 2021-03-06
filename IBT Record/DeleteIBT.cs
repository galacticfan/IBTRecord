﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBT_Record
{
    public partial class DeleteIBT : Form
    {
        private string password;

        public DeleteIBT(string pass)
        {
            InitializeComponent();
            password = pass;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (passTxtBox.Text == password)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
