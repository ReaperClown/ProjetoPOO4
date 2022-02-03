using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPOO4
{
    public partial class FrmMultiplo5 : Form
    {
        Operations op = new Operations();

        public FrmMultiplo5()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                verticalCentered();
                int num = int.Parse(textBNumber.Text);
                textBResult.Text += op.multipleFive(num);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor numérico para realizar o cálculo.", "Valor inválido");
                cleanFields();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanFields();
        }

        private void cleanFields()
        {
            textBNumber.Clear();
            textBResult.Clear();
            textBNumber.Focus();
        }

        private void verticalCentered()
        {
            textBResult.Clear();
            textBResult.ForeColor = Color.DodgerBlue;
            textBResult.TextAlign = HorizontalAlignment.Center;
            int a = textBResult.Size.Height;
            float c = textBResult.Font.Height;
            for (int i = 0; i < (int)(a / c) / 3.5; i++)
            {
                textBResult.Text += "\r\n";
            }
        }

        private void textBNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label1.DisplayRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }
    }
}
