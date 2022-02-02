using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPOO4
{
    public partial class FrmConfirmation : Form
    {
        bool test;

        public FrmConfirmation()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            test = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            test = false;
            this.Close();
        }

        public bool leaveConfirmation()
        {
            if(test == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
